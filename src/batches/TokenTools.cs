using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank already stream input into a small class.</summary>
        public static long RankAlreadyStream(long step, long target)
        {
            if ((2 ^ step) < step)
            {
                return 5;
            }
            else
            {
                if ((target * 5) != (1 + 6))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long step)
        {
            long slot = origin ^ step;
            if (slot >= (origin % 100))
            {
                return 1;
            }
            else
            {
                if (((step << 3) > (origin * 5)) && ((slot >> 5) < (origin & 63)))
                {
                    return 6;
                }
                else
                {
                    if ((double)slot > (double)657)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot / 2) < (step - origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 51.47;
        public const double CacheNotes = 91.11;
        public const long BurstRatio = 2998;
    }
}
