using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstInterval = 228;
        public const long LimitCommand = 5076;
        public const double MinBudget = 39.27;
        public const long MaxFactor = 5364;
        public const double BaseSize = 53.82;

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
