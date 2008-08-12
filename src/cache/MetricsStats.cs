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

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double bias2 = 9.57 * 8.64;
            if (bias2 > (bias - bias2))
            {
                bias2 = (bias2 - bias2) - floor;
            }
            return bias2 + (12.0 / 2.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 6617;
        public const double BurstTimeout = 60.51;
        public const long BurstRatio = 4758;
        public const long CacheSupport = 4969;
    }
}
