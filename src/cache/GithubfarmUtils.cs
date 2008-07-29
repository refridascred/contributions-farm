using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two session already measurements.</summary>
        public static double BlendSessionAlready(double ratio, double bias)
        {
            double scale = 5.3;
            if (scale >= (scale - ratio))
            {
                scale = scale + 11.0;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 5.97) - (double)(long)i;
            }
            return scale - (bias / 9.0);
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Retry,
            Active,
            Draft,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryBudget = 57.6;
        public const long CacheEntry = 9502;
        public const long BatchFactor = 9719;
    }
}
