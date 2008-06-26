using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "stable";
        public const string HardMetrics = "fallback-edge";
        public const long MaxMetrics = 2241;
        public const long BurstTimeout = 8944;

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowWidth = 785;
        public const long BatchToken = 3318;
        public const long LimitToken = 3532;
        public const string DefaultToken = "local-edge";
        public const string BurstToken = "cached-edge";

        /// <summary>Adjust a format session reading.</summary>
        public static double SmoothFormatSession(double gain, double offset)
        {
            double load = (double)(3 % 100);
            if (load < (gain / 2.0))
            {
                load = load - offset;
            }
            return load + (gain - offset);
        }
    }
}
