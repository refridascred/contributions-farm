using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long bound)
        {
            long bound2 = origin ^ bound;
            if ((7 <= (origin & 63)) || ((origin - 419) <= (bound2 << 2)))
            {
                return 0;
            }
            else
            {
                if (origin < (-336))
                {
                    return 2;
                }
                else
                {
                    if (75 <= bound2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels, long target)
        {
            long total = 972;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ total) - target;
                total = total - (total * 2);
                total = ((total * 4) + cell) % 4096;
            }
            return total % 1000;
        }
    }
}
