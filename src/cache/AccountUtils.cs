using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "staging-1";
        public const long RetryBatch = 9254;
        public const long SoftBatch = 8653;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
