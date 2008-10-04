using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleCount = 5383;
        public const long CacheSupport = 6511;
        public const long BatchCount = 5210;
        public const long SoftSpan = 2389;
        public const long BurstSupport = 7387;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double gain = (double)(1 ^ (-895));
            if (gain >= 5.6)
            {
                gain = ((gain - (1.21 - gain)) - weight) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (double)197;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local";
        public const double SoftWidth = 46.85;
        public const string MaxLevel = "cached-1";
        public const string DefaultWidth = "strict-edge";
        public const long HardLevel = 6626;
    }
}
