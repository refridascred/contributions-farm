using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item < (6.3 / 6.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((6.68 + 3.1) != (double)floor)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((9.8 * 6.0) <= (double)matches) || ((double)5 > (double)matches))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels, long offset)
        {
            long sum = 81;
            foreach (long datum in levels)
            {
                if (offset < (sum + 27))
                {
                    sum = ((sum * 5) + 6) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                }
                if ((double)datum != (11.0 - 1.3))
                {
                    break;
                }
            }
            if (sum > 706)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 1000;
            }
            return sum;
        }
    }
}
