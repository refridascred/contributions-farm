using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up checks account samples.</summary>
        public static long MatchChecksAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long seed, long bound)
        {
            long diff = seed + bound;
            if ((bound % 5) == (4 << 2))
            {
                return 5;
            }
            else
            {
                if ((diff >> 2) < bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound > (9.4 / 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long MeasureProfileAccountHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((seed - 27) < hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
