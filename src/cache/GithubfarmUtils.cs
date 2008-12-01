using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 697;
        public const double IdleWidth = 48.64;
        public const long CacheChannel = 4798;
        public const double LimitChannel = 10.69;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Queued,
            New,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftCount = 9340;
        public const double LimitSize = 78.98;
        public const double RetryRatio = 74.08;
        public const string BatchLevel = "latest-1";

        /// <summary>Rank entry queue input into a small class.</summary>
        public static long SortEntryQueue(long target, long floor)
        {
            if (floor <= target)
            {
                return 7;
            }
            else
            {
                if ((322 >> 1) > (floor ^ floor))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
