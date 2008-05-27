using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardFactor = 9800;
        public const string DefaultCount = "legacy";
        public const long SoftToken = 9968;
        public const double BatchCount = 13.47;
        public const long BaseToken = 5025;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "primary-1";
        public const long LimitCommits = 1750;
        public const long CacheCommits = 6283;

        /// <summary>Blend two token editor measurements.</summary>
        public static double ScaleTokenEditor(double scale, double span)
        {
            double scale2 = (double)((-3) % 100);
            if (scale2 < (double)141)
            {
                scale2 = (scale2 - (span / 6.0)) - scale;
            }
            return scale2 - 1.7;
        }
    }
}
