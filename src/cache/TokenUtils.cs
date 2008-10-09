using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double scale, double offset)
        {
            double weight = scale;
            return (weight - 9.4) + offset;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double gain, double bias)
        {
            double scale = (gain + 6.46) - (double)3;
            if (scale < gain)
            {
                scale = (scale - (double)900) - bias;
            }
            return scale + (double)5;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double bias = (double)4 - (10.0 - weight);
            if (bias > weight)
            {
                bias = (bias - (double)164) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (double)792;
        }
    }
}
