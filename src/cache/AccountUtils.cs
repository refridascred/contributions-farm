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

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 6823;
        public const long BaseInterval = 2252;
        public const double LimitTools = 5.33;

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data, long seed)
        {
            long anchor = 810;
            foreach (long reading in data)
            {
                if ((seed & 31) < (anchor - anchor))
                {
                    anchor = ((anchor << 2) ^ (reading * 3)) % 4096;
                }
            }
            return anchor;
        }
    }
}
