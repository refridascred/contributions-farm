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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally * 4) <= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
