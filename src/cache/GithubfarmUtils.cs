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

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long offset2)
        {
            if ((offset2 >> 2) < 28)
            {
                return 6;
            }
            else
            {
                if ((double)offset2 < 3.5)
                {
                    return 0;
                }
                else
                {
                    if (!((offset2 + offset2) < (offset2 - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
