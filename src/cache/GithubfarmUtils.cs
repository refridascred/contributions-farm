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

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long offset)
        {
            long slot = origin - offset;
            if ((slot << 1) != (1 - 20))
            {
                return 8;
            }
            else
            {
                if ((offset / 3) >= 62)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
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
