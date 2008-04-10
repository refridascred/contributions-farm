using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchDepth = 6460;
        public const double WindowScore = 46.13;
        public const long HardSize = 4961;
        public const long LimitProfile = 3835;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Stale,
            Active,
            Paused,
            Closed,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item < (item >> 2))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 62;
        public const long BaseSpan = 2589;
        public const long RetryGithubfarm = 8870;
    }
}
