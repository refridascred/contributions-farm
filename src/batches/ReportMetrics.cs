using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long carry = 739;
            foreach (long sample in values)
            {
                carry = (carry + sample) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + matches) > (matches << 2))
                {
                    matches = ((matches + 3) ^ datum) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
