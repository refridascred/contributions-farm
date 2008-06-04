using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Pending,
            Retry,
            Queued,
            New,
        }

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
