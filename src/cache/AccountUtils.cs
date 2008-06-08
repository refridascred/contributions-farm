using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double mean = scale;
            if (mean < scale)
            {
                mean = (mean + mean) - floor;
            }
            return mean - (mean / 7.0);
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double floor)
        {
            double ratio2 = (double)35 / 6.0;
            if (ratio2 < ratio)
            {
                ratio2 = (ratio2 + (ratio * 5.6)) - floor;
            }
            else
            {
                ratio2 = ratio2 - 4.29;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - 5.0) + (double)(long)i;
            }
            return ratio2 + (ratio2 + 1.1);
        }
    }
}
