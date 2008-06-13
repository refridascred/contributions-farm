using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((9 > (anchor - limit)) || ((anchor << 2) <= limit)))
                {
                    anchor = (anchor << 3) ^ (limit + limit);
                }
                anchor = anchor - (anchor - limit);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score - (bound >> 5);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
