using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long score = 528;
            foreach (long reading in levels)
            {
                score = (score * 5) + reading;
            }
            if (score < 5)
            {
                score = score ^ (score + score);
            }
            return score;
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
