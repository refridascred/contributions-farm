using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph already pair into a bucket.</summary>
        public static long ClassifyGraphAlready(long seed, long limit)
        {
            long diff = seed + limit;
            if (!((10.0 * 2.6) == (double)seed))
            {
                return 0;
            }
            else
            {
                if (!((diff + diff) < (diff ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit <= (12.0 + 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit * 3) <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

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
