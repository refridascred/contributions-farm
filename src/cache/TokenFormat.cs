using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 9523;
        public const long MinEntry = 6566;
        public const long LimitSpan = 8315;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 23.05;
        public const long SoftTimeout = 8752;
        public const long DefaultGithubfarm = 5145;
    }
}
