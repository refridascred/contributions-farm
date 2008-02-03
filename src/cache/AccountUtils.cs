using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxWidth = 9793;
        public const double StepTimeout = 83.79;
        public const long BurstPayload = 9511;
        public const string RetryPayload = "cached";
        public const long BurstTimeout = 4288;

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultSpan = 3218;
        public const long HardWidth = 5579;
        public const long MaxBudget = 614;
        public const string RetryWindow = "open-1";
    }
}
