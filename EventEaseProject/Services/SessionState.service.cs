public class SessionStateService
{
    public string Username { get; private set; } = "Guest";
    public bool IsLoggedIn => Username != "Guest";

    public void RegisterUser(string username)
    {
        if (!string.IsNullOrWhiteSpace(username))
        {
            Username = username;
        }
    }
}