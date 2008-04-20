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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((offset & 1) >= (offset - 685))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
