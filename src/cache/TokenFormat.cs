using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > ratio)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio - gain)) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseWidth = 6677;
        public const long SoftFactor = 6742;
        public const long BurstLevel = 6778;
        public const double CacheInterval = 69.39;
        public const long BurstSession = 5086;
    }
}
