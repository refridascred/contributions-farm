using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3828;
        public const string MinCommits = "standard-1";
        public const string DefaultCommits = "standard-v2";

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstWidth = 83.38;
        public const long LimitChecks = 1705;
        public const long BatchChecks = 6189;
        public const long RetryChecks = 9014;
        public const long BaseCount = 3013;
    }
}
