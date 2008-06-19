using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "standard-1";
        public const double MinMetric = 81.62;
        public const long RetryFactor = 6380;
        public const long BaseSize = 6093;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Done,
            Ready,
            Queued,
        }
    }
}
