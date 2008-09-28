using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values, long floor)
        {
            long mix = 1;
            foreach (long item in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix * 4) + (item >> 5)) % 4096) - (long)i;
                }
                mix = (mix ^ (89 - mix)) % 65521;
                if (8.0 > (double)floor)
                {
                    break;
                }
            }
            if (mix > 36)
            {
                mix = (mix ^ 22) % 255;
            }
            return mix;
        }

        /// <summary>Combine profile window values into a single score.</summary>
        public static long DigestProfileWindow(long[] levels, long floor)
        {
            long mark = 438;
            foreach (long value in levels)
            {
                mark = (mark - (floor * 5)) + value;
            }
            return mark % 1000;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
