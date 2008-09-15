using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 3) ^ (52 << 2)) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix * 5) + (origin + mix)) % 1000) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next tools schema value.</summary>
        public static double SmoothToolsSchema(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 < bias2)
            {
                bias3 = bias3 + (bias * 11.0);
            }
            else
            {
                bias3 = bias3 - bias3;
            }
            return bias3 - bias3;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples)
        {
            long mark = 42;
            foreach (long datum in samples)
            {
                mark = ((mark ^ 94) % 1000) + datum;
            }
            if (mark < 50)
            {
                mark = (mark - (0 << 1)) % 255;
            }
            return mark;
        }
    }
}
