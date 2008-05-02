using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long origin, long floor)
        {
            if (!((floor - origin) < (origin - 5)))
            {
                return 7;
            }
            else
            {
                if (((origin - origin) == (floor * 4)) || ((origin >> 3) < (floor << 3)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long bound)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                if (((17.0 / 9.0) >= (double)datum) || ((datum & 31) >= (mark / 4)))
                {
                    mark = (((mark << 2) ^ datum) % 97) - bound;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ (mark ^ (long)series.Length)) % 101;
            }
            return mark;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix << 3) ^ (step + mix)) % 255;
                if (((mix + mix) < (step << 1)) && (step < (step & 63)))
                {
                    mix = ((mix << 2) ^ (step & 15)) % 101;
                }
                else
                {
                    mix = mix - (mix % 97);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
