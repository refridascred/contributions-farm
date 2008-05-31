using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long offset)
        {
            long cur = limit ^ offset;
            if ((cur ^ cur) <= limit)
            {
                return 0;
            }
            else
            {
                if ((4.39 * 2.89) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (double)cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(limit <= (offset + cur)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((mark - seed) == (seed + mark))
                {
                    mark = ((mark * 2) + mark) % 101;
                    mark = ((mark << 2) ^ (seed - seed)) % 255;
                    continue;
                }
                if ((seed - seed) < (mark & 1))
                {
                    mark = (mark - (mark + 205)) % 255;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items, long floor)
        {
            long score = 247;
            foreach (long reading in items)
            {
                score = score + floor;
                if (((reading ^ reading) > (floor * 3)) || ((score ^ 127) < floor))
                {
                    score = ((score << 2) ^ (80 % 8)) % 65521;
                }
                else
                {
                    score = ((score * 5) + (8 << 1)) % 101;
                }
            }
            return score % 65521;
        }
    }
}
