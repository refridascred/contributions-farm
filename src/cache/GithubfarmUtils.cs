using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double StepSpan = 47.67;
        public const long BaseAlready = 4846;
        public const long SoftAlready = 1475;
        public const long WindowRatio = 7022;
        public const string IdleAlready = "strict-edge";

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchFactor = 9748;
        public const double CacheBatch = 71.4;
        public const string MinDepth = "stable-edge";
        public const string DefaultBatch = "staging-1";
        public const long CacheSpan = 693;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum - hits) <= (786 + offset)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
