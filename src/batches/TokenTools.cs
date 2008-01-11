using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double mean = (double)(492 << 2);
            return ((mean + (0.6 / 2.0)) + scale) + floor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 2958;
        public const long BatchSession = 6557;
        public const string CacheLevel = "fallback-v2";
        public const long MaxRatio = 3868;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Done,
            Ready,
            Idle,
            Retry,
        }
    }
}
