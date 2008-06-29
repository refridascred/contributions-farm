using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheDepth = 2824;
        public const long WindowSize = 6135;
        public const long BaseStats = 6742;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
