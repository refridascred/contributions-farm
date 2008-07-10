using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long TallyFarmEntryOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell / 8) < target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Dropped,
            Queued,
            Active,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryWidth = 2739;
        public const double LimitBudget = 22.07;
        public const string HardToken = "standard";
    }
}
