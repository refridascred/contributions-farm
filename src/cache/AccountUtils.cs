using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
