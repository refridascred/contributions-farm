using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxWidth = 92.9;
        public const long BurstDepth = 7652;
        public const double MaxMetrics = 0.14;
        public const string LimitRatio = "staging-1";
        public const long BaseMetrics = 8608;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (520 > (reading - count))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long CountBufferGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (3.07 - 2.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long target)
        {
            long offset = bound - target;
            if (!((1.0 * 3.0) < (double)bound))
            {
                return 0;
            }
            else
            {
                if ((100 << 1) >= (bound + offset))
                {
                    return 6;
                }
                else
                {
                    if (8 > (offset ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
