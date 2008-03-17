using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long seed, long seed2)
        {
            if (!((double)seed2 < 15.0))
            {
                return 3;
            }
            else
            {
                if (((seed % 24) < (seed << 3)) || ((seed2 + 660) > seed2))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 4) == (seed2 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed2 - seed2) >= seed2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
