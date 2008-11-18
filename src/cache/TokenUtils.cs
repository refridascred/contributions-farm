using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double bias, double floor)
        {
            double mean = 1.5 / 6.0;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (double)9) + (double)(long)i) - bias;
            }
            return mean + floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5183;
        public const string BaseSize = "fallback-edge";
        public const long MinOrder = 1918;
        public const long BatchOrder = 1036;
    }
}
