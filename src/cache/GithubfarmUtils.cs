using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (7.3 + 2.06))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item & 31) < (item + target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseInterval = 363;
        public const long BurstCount = 9926;
        public const double StepCommits = 36.55;
        public const long CacheLevel = 2162;
        public const long CacheBudget = 3131;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            New,
            Locked,
            Synced,
        }
    }
}
