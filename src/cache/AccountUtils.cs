using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double gain, double floor)
        {
            double scale = (double)(59 >> 2);
            if (scale < scale)
            {
                scale = (scale - 8.65) + floor;
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (5.25 / 5.0)) + (double)(long)i;
            }
            return scale + (gain + 0.2);
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double scale, double offset)
        {
            double bias = (7.0 + offset) * 2.2;
            if (bias < (double)2)
            {
                bias = bias - (scale * 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (3.44 + offset);
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
