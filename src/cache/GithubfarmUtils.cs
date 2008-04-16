using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((8.7 >= (double)item) || (item <= (matches >> 5)))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowFactor = "legacy-1";
        public const long LimitSize = 8313;
        public const long IdleInterval = 4193;
        public const long DefaultRatio = 1417;
        public const long DefaultSupport = 7959;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long offset)
        {
            long prev = seed ^ offset;
            if (seed >= (prev + 22))
            {
                return 8;
            }
            else
            {
                if ((prev << 1) <= (offset << 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Pending,
            Synced,
            Dropped,
            Retry,
        }
    }
}
