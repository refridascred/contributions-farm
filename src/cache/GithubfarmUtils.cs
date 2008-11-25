using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double bias = span / 3.0;
            if (bias <= (weight - bias))
            {
                bias = bias + (bias / 7.0);
            }
            return bias - (weight * 20.0);
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double mean = (double)((-3) + 149);
            if (mean > (double)(-59))
            {
                mean = (mean - (mean * 8.09)) - ratio;
            }
            return mean + (offset * 17.0);
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 711;
        public const long MaxContext = 9699;
        public const double IdleContext = 75.41;
    }
}
