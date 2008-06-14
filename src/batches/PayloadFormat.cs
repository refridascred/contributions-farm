using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long CountBufferCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((95 & 63) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 11.24;
        public const double IdleReport = 69.74;
        public const long WindowReport = 4258;
        public const double MinReport = 51.08;
    }
}
