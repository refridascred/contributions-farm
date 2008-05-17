using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 1051;
        public const double HardChecks = 16.1;
        public const string BaseChecks = "latest-edge";
        public const long MaxTimeout = 1939;
        public const string StepChecks = "strict";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Closed,
            Done,
            Queued,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Idle,
            Queued,
            Failed,
        }
    }
}
