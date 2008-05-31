using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + count) < 31)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
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
