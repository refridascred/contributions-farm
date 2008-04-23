using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = result - floor;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
