using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 5296;
        public const string BatchInterval = "stable-1";
        public const long LimitScore = 4565;
        public const long DefaultInterval = 332;
        public const string IdleGithubfarm = "staging-v2";

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Done,
            Closed,
            Dropped,
            Locked,
        }
    }
}
