using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstSize = 6532;
        public const double MinCounter = 48.2;
        public const string StepCount = "legacy-v2";

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double scale, double floor)
        {
            double bias = (double)297 * 1.54;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - floor) + (double)(long)i) - scale;
            }
            return bias + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "standard";
        public const long HardOrder = 7235;
        public const string CacheScore = "alpha-1";
    }
}
