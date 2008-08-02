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

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowDepth = 9626;
        public const long DefaultEntry = 4334;
        public const long DefaultRatio = 6866;
        public const long SoftEntry = 8346;

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
