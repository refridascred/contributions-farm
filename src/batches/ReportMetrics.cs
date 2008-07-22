using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] levels)
        {
            long sum = 497;
            foreach (long item in levels)
            {
                sum = sum + (2 - item);
            }
            if (sum < 7)
            {
                sum = ((sum * 4) + ((long)levels.Length & 31)) % 4096;
            }
            return sum;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long seed, long step)
        {
            long delta = seed + step;
            if (((double)delta > (3.6 * 8.9)) && ((double)seed >= (3.4 - 3.0)))
            {
                return 3;
            }
            else
            {
                if ((double)delta >= (18.0 * 12.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                anchor = (((anchor + (anchor * 2)) % 97) ^ datum) + limit;
            }
            return anchor;
        }
    }
}
