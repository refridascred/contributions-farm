using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context contributi values into a single score.</summary>
        public static long CombineContextContributi(long[] samples, long target)
        {
            long mix = 5;
            foreach (long cell in samples)
            {
                if (target >= (1 * 5))
                {
                    mix = (((mix * 2) + mix) % 101) - cell;
                }
                mix = (mix ^ (7 + 9)) % 4096;
            }
            if (mix > 58)
            {
                mix = (mix + (420 - target)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double bias2 = 5.69 - (double)88;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (((bias2 + (6.5 / 4.0)) + (double)(long)i) - ratio) - bias;
            }
            return bias2 - (bias2 / 8.0);
        }
    }
}
