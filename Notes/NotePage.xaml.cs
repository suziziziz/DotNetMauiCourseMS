namespace Notes;

public partial class NotePage : ContentPage
{
	string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

	public NotePage()
	{
		InitializeComponent();

		if (File.Exists(_fileName))
			TextEditor.Text = File.ReadAllText(_fileName);
	}

	public void SaveButton_Clicked(object sender, EventArgs e)
	{
		File.WriteAllText(_fileName, TextEditor.Text);
	}

	public void DeleteButton_Clicked(object sender, EventArgs e)
	{
		if (File.Exists(_fileName))
			File.Delete(_fileName);

		TextEditor.Text = String.Empty;
	}
}