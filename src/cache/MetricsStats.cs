using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double bias2 = (2.0 * 7.0) / 3.0;
            if (bias2 >= (weight * 0.9))
            {
                bias2 = (bias2 - (bias2 + bias2)) - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (double)5;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstFactor = 667;
        public const long BatchInterval = 8468;
        public const long BaseCounter = 732;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultWidth = 2466;
        public const long IdleLevel = 4025;
        public const double BurstLevel = 84.92;
        public const double WindowBatch = 67.34;
        public const long BaseWidth = 3669;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 6617;
        public const double BurstTimeout = 60.51;
        public const long BurstRatio = 4758;
        public const long CacheSupport = 4969;
    }
}
