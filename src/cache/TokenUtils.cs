using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 6382;
        public const string LimitGraph = "local";
        public const string RetryFactor = "latest-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowWidth = 785;
        public const long BatchToken = 3318;
        public const long LimitToken = 3532;
        public const string DefaultToken = "local-edge";
        public const string BurstToken = "cached-edge";

        /// <summary>Blend two cache tools measurements.</summary>
        public static double ScaleCacheTools(double rate, double bias)
        {
            double weight = bias / 9.0;
            if (weight >= (bias + rate))
            {
                weight = weight - (double)3;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)5) - (double)(long)i;
            }
            return weight - 5.0;
        }
    }
}
