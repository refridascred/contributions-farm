using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((mark & 63) > (bound / 7))
                {
                    mark = (mark + (mark + mark)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of route stats readings.</summary>
        public static long OverlapRouteStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)seed <= (double)matches) && ((matches >> 1) < (matches + matches)))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long seed)
        {
            long mix = 3;
            foreach (long entry in series)
            {
                mix = ((mix + (entry & 31)) % 97) + seed;
            }
            return mix;
        }
    }
}
