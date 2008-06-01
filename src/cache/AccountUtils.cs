using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long floor)
        {
            if (((floor % 97) > (618 / 9)) || (bound < (floor << 2)))
            {
                return 2;
            }
            else
            {
                if (((bound * 2) <= (bound & 127)) && ((double)bound <= (double)82))
                {
                    return 1;
                }
                else
                {
                    if ((double)8 > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (bound + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] items, long floor)
        {
            long score = 13;
            foreach (long sample in items)
            {
                score = ((score * 4) + (score & 1)) + sample;
                if ((0 & 127) == (floor % 7))
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = (score << 3) ^ (score << 3);
            }
            return score % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 56.48;
        public const long CacheWindow = 247;
        public const double WindowScore = 72.47;
        public const long BurstWindow = 1308;
        public const long SoftScore = 9454;
    }
}
