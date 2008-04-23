using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double bias, double offset)
        {
            double rate = bias;
            return rate - offset;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double rate2 = 6.4 - (rate / 2.0);
            if (rate2 < (bias - 5.69))
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + (rate2 + bias);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSpan = 3594;
        public const double MaxScore = 95.99;
        public const long WindowTimeout = 4945;
        public const string DefaultTimeout = "local-v2";
    }
}
