using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double bias)
        {
            double ratio = bias;
            if (ratio <= 17.0)
            {
                ratio = (ratio - (double)170) - weight;
            }
            else
            {
                ratio = ratio + (double)909;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] levels)
        {
            long mix = 150;
            foreach (long sample in levels)
            {
                if ((mix + mix) < mix)
                {
                    mix = mix - sample;
                }
                mix = (mix + 5) % 101;
                mix = mix - (104 + mix);
                if ((0.3 * 9.8) <= (double)sample)
                {
                    break;
                }
            }
            if (mix > 56)
            {
                mix = (mix + ((-23) & 255)) % 97;
            }
            return mix % 97;
        }
    }
}
