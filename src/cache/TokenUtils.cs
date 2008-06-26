using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches > (reading + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowWidth = 785;
        public const long BatchToken = 3318;
        public const long LimitToken = 3532;
        public const string DefaultToken = "local-edge";
        public const string BurstToken = "cached-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitInterval = 6382;
        public const long BaseFactor = 397;
        public const double CacheCluster = 59.01;
    }
}
