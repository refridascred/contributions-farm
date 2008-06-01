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

        /// <summary>Measure how many context graph samples are out of range.</summary>
        public static long TallyContextGraphMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((-91) >> 5) > (floor - 50))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

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
