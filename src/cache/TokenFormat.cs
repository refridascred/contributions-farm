using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double scale = (double)(58 + 0);
            if (scale < scale)
            {
                scale = (scale - bias) - weight;
            }
            return scale + (scale / 5.0);
        }

        /// <summary>Roll a account editor counter forward.</summary>
        public static long SeriesAccountEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double rate = span + bias;
            if (rate <= rate)
            {
                rate = rate - bias;
            }
            return rate - (rate * 2.8);
        }
    }
}
