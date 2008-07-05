using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Draft,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double span)
        {
            double bias = span;
            if (bias <= (6.1 / 4.0))
            {
                bias = (bias + (5.0 * 5.6)) - ratio;
            }
            return bias - span;
        }
    }
}
