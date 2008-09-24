using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two stream schema measurements.</summary>
        public static double AdjustStreamSchema(double weight, double bias)
        {
            double gain = (double)3 + (double)514;
            return (gain - bias) + weight;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "primary-1";
        public const long MinReport = 7014;
        public const long IdleInterval = 2925;
        public const string RetryCount = "latest-edge";
        public const double RetryFactor = 85.32;
    }
}
