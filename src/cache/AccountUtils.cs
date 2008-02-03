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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((origin + 831) != (value + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
