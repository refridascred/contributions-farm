using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long step, long seed)
        {
            if ((step > (step + step)) || ((step / 6) < 12))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (4.1 / 4.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a metrics batches sample.</summary>
        public static long LocateMetricsBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token profile entries that pass the check.</summary>
        public static long CountTokenProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((93 + 1) > value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
