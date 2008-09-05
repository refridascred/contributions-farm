using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a stats editor reading.</summary>
        public static double ScaleStatsEditor(double weight, double floor)
        {
            double load = weight / 6.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - load) + (double)(long)i) + floor;
            }
            return load - 4.44;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 820;
        public const double BurstContributi = 78.73;
        public const long MinContributi = 5161;
        public const long MinRatio = 7048;
        public const long SoftScore = 8251;

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "fallback-1";
        public const double RetrySchema = 50.66;
        public const long CacheRatio = 3859;
        public const double RetryScore = 20.41;
        public const string MaxCount = "alpha-1";
    }
}
