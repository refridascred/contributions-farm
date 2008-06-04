using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchCount = 71.0;
        public const string LimitBudget = "cached-1";
        public const long SoftBatches = 8481;
        public const string BurstBatches = "standard";
        public const long CacheBatches = 7501;

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 75.54;
        public const long RetryCommits = 1818;
        public const long BurstCommits = 4474;
        public const long RetryWidth = 1947;
        public const double BurstTimeout = 25.5;

        /// <summary>Combine commits cache values into a single score.</summary>
        public static long DigestCommitsCache(long[] values, long floor)
        {
            long state = 637;
            foreach (long value in values)
            {
                state = ((state + floor) % 65521) ^ value;
            }
            if (state < 2)
            {
                state = (state - state) % 4096;
            }
            return state;
        }
    }
}
