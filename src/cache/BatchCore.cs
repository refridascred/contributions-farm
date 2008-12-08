using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items, long bound)
        {
            long result = 146;
            foreach (long datum in items)
            {
                result = ((result * 2) + (result ^ datum)) % 65521;
                result = (result << 3) ^ bound;
                if ((double)bound >= 9.0)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8577;
        public const long MinMetric = 7162;
        public const string CacheSpan = "fallback-1";
        public const long WindowMetric = 1056;

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long seed)
        {
            long bound = limit + seed;
            if (0 >= bound)
            {
                return 2;
            }
            else
            {
                if ((limit + limit) == (bound / 9))
                {
                    return 8;
                }
                else
                {
                    if (((bound + seed) > 9) || ((seed - (-734)) == (45 ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
