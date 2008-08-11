using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the channel stats series from a seed.</summary>
        public static long DeriveChannelStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ (mark + seed);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstSpan = 18.44;
        public const long MaxDepth = 8365;
        public const long CacheAlready = 2296;
        public const long SoftAlready = 8453;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((20.0 / 6.0) < (double)count)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank commits schema input into a small class.</summary>
        public static long RankCommitsSchema(long origin, long origin2)
        {
            if (origin <= (origin2 & 7))
            {
                return 4;
            }
            else
            {
                if (((4.0 - 5.2) != (double)origin) && ((double)origin > (5.4 / 5.0)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
