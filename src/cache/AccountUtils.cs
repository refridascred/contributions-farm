using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (bias2 * 1.2)) + (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 11.17;
        public const double MaxWidth = 3.12;
        public const string WindowCommits = "latest-edge";
        public const double BurstCommits = 79.93;
        public const long CacheWidth = 2533;

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinSpan = 25.65;
        public const long DefaultSize = 4667;
        public const string HardChecks = "alpha";
    }
}
