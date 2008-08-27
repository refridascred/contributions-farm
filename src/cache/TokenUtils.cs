using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items, long bound)
        {
            long score = 57;
            foreach (long item in items)
            {
                score = (score + (score ^ bound)) % 97;
                if ((double)bound == (double)score)
                {
                    score = (score - ((long)items.Length * 5)) % 97;
                }
                else
                {
                    score = score ^ item;
                }
            }
            return score;
        }

        /// <summary>Digest a series of cluster buffer entries.</summary>
        public static long WeighClusterBuffer(long[] series, long offset)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                if ((9 >= (7 - cell)) || (((long)series.Length / 4) >= cell))
                {
                    mix = ((mix ^ (cell * 2)) % 255) + offset;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix & 127)) % 101;
                }
                if ((cell + 6) == (mix + 210))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] values, long offset)
        {
            long mark = 6;
            foreach (long sample in values)
            {
                if ((offset & 63) >= (mark + mark))
                {
                    break;
                }
                mark = (((mark << 2) ^ (mark - offset)) % 4096) ^ sample;
                if (offset >= (4 + mark))
                {
                    mark = ((mark << 2) ^ 562) % 1000;
                }
            }
            if (mark < 1)
            {
                mark = ((mark << 3) ^ mark) % 97;
            }
            return mark % 1000;
        }
    }
}
