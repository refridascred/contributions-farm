using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two checks route measurements.</summary>
        public static double AdjustChecksRoute(double bias, double span)
        {
            double gain = (13.0 / 4.0) - (bias - span);
            return gain + 5.0;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepRatio = 6673;
        public const long CacheSpan = 1173;
        public const double SoftMetrics = 15.38;
        public const long BurstMetrics = 6688;

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSize = 6200;
        public const long MinChannel = 1148;
        public const long RetryWidth = 5716;
        public const string RetryBudget = "fallback-edge";

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long bound, long seed)
        {
            if (5 >= (bound * 5))
            {
                return 8;
            }
            else
            {
                if (seed > (seed * 5))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
