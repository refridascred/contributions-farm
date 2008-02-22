using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double floor)
        {
            double load = bias;
            for (int i = 0; i < 9; i++)
            {
                load = (load + floor) - (double)(long)i;
            }
            return load - (double)1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double scale2 = 2.0 / 3.0;
            return ((scale2 - scale2) + scale) + floor;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double rate = bias;
            if (rate <= scale)
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)695) + (double)(long)i;
            }
            return rate + (bias / 8.0);
        }
    }
}
