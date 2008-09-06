using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2821;
        public const double RetryChecks = 53.24;
        public const long CacheChecks = 8095;
        public const string IdleChecks = "latest-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 76.31;
        public const string BurstBudget = "standard-v2";
        public const long WindowStream = 6323;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Active,
            Draft,
            Closed,
        }
    }
}
