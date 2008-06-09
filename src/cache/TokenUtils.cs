using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 64.13;
        public const long MinFactor = 1552;
        public const string WindowScore = "cached-edge";
        public const string IdleCache = "staging-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 98.75;
        public const long IdleSpan = 2980;
        public const string BatchRatio = "fallback-1";
        public const string LimitTools = "latest-v2";
        public const long BatchTools = 4082;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double ratio = (1.0 / 9.0) + (rate - span);
            if (ratio >= rate)
            {
                ratio = ratio - (rate / 3.0);
            }
            return ratio - (double)4;
        }
    }
}
