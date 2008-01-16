using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleDepth = 765;
        public const long IdleCounter = 5411;
        public const double DefaultSpan = 44.81;

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double weight2 = (double)64 - (7.8 / 2.0);
            if (weight2 < (double)(-8))
            {
                weight2 = (weight2 + (weight + 8.0)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 6568;
        public const long CacheSession = 7942;
        public const string HardSession = "cached-v2";
        public const string MinSession = "strict-edge";
        public const double BatchSize = 62.2;
    }
}
