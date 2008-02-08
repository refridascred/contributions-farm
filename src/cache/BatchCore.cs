using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardInterval = 6220;
        public const long CacheWidth = 472;
        public const long BatchFactor = 3961;
        public const long CacheBatch = 4351;

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long score = -20;
            foreach (long entry in items)
            {
                score = score ^ (entry + score);
            }
            return score % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long limit, long floor)
        {
            if ((251 & 7) > (limit + 0))
            {
                return 5;
            }
            else
            {
                if ((floor ^ floor) < (floor >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((floor % 97) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)floor < (7.82 - 14.0)) && ((8.06 - 6.0) < (double)limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
