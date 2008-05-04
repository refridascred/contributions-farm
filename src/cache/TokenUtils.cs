using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double ratio = span / 4.0;
            if (ratio > 9.5)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + (span - gain);
            }
            return ratio + (3.0 + span);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 14.94;
        public const long CacheCount = 3342;
        public const double HardInterval = 18.76;
        public const long IdleTimeout = 9998;

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 6311;
        public const double MaxFormat = 43.96;
        public const double StepTimeout = 77.5;
    }
}
