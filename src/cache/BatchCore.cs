using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two checks batch measurements.</summary>
        public static double BlendChecksBatch(double weight, double span)
        {
            double mean = weight / 3.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)(long)i) - span;
            }
            return mean + (weight * 10.0);
        }

        /// <summary>Look up the position of a cluster commits sample.</summary>
        public static long FindClusterCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count ^ 73) >= count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
