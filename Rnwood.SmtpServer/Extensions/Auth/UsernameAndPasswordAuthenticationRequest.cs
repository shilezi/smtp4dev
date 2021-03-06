﻿namespace Rnwood.SmtpServer.Extensions.Auth
{
    public class UsernameAndPasswordAuthenticationRequest : IAuthenticationCredentials
    {
        public UsernameAndPasswordAuthenticationRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; private set; }
        public string Password { get; private set; }
    }
}