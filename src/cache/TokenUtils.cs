using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double rate2 = offset / 5.0;
            if (rate2 < (double)277)
            {
                rate2 = (rate2 - offset) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + offset) + (double)(long)i;
            }
            return rate2 + 1.6;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowScore = 2575;
        public const long MaxSize = 6617;
        public const string BatchCommand = "legacy-edge";
        public const long CacheRatio = 6629;
        public const double BatchFactor = 89.68;

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitCount = 5994;
        public const long BaseWindow = 3318;
        public const long StepWindow = 3609;
        public const string MaxWindow = "latest-v2";
    }
}
