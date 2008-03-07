using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardCluster = 23.36;
        public const long CacheSpan = 1659;
        public const long RetryCluster = 96;
        public const long LimitCluster = 5773;

        /// <summary>Rank checks channel input into a small class.</summary>
        public static long RankChecksChannel(long seed, long limit)
        {
            long prev = seed + limit;
            if ((limit ^ prev) >= seed)
            {
                return 3;
            }
            else
            {
                if (seed < (prev % 100))
                {
                    return 5;
                }
                else
                {
                    if ((8.25 + 8.0) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading > (711 & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
