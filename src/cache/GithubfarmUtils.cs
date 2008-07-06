using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((17.0 - 3.7) < (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "staging-1";
        public const double IdleLayout = 82.7;
        public const long BatchLayout = 4427;
        public const long BaseBudget = 6786;
        public const long DefaultInterval = 6604;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 6478;
        public const double IdleRatio = 85.28;
        public const double CacheEntry = 12.64;
        public const long BatchEntry = 6757;
        public const long BatchRatio = 782;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Closed,
        }
    }
}
