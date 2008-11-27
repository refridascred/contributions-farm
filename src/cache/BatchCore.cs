using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxFactor = 9483;
        public const long HardNotes = 3557;
        public const long SoftNotes = 3554;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long floor, long offset)
        {
            if ((floor % 8) == (floor ^ floor))
            {
                return 0;
            }
            else
            {
                if ((floor * 2) < offset)
                {
                    return 5;
                }
                else
                {
                    if ((14.0 / 8.0) == (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first order stats entry that matches the target.</summary>
        public static long FindOrderStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
