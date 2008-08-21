using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Done,
            New,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2490;
        public const long IdleInterval = 4318;
        public const string BaseRoute = "stable-v2";

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Closed,
            Synced,
            New,
            Pending,
        }
    }
}
