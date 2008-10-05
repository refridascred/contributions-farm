using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - sum) % 1000;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "fallback-edge";
        public const long CacheTimeout = 5372;
        public const long HardCommand = 134;
        public const double WindowCommand = 9.13;

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseSpan = 3805;
        public const double BurstCommand = 67.37;
        public const double BurstFactor = 39.96;
        public const double LimitCommand = 12.64;
        public const long DefaultScore = 9094;
    }
}
