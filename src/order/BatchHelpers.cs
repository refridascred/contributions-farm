using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values, long limit)
        {
            long result = 21;
            foreach (long item in values)
            {
                if (!((item & 7) >= item))
                {
                    result = result ^ (34 >> 5);
                    result = (result + (item & 127)) % 4096;
                }
                result = result - limit;
            }
            return result % 1000;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long seed, long origin)
        {
            if ((double)seed != (5.7 * 12.0))
            {
                return 8;
            }
            else
            {
                if ((8.7 >= (double)origin) || (0 <= (seed % 3)))
                {
                    return 0;
                }
                else
                {
                    if (!((seed << 2) >= (origin >> 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
