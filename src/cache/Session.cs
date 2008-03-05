using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Synced,
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowCount = "local";
        public const string LimitWidth = "primary";
        public const string DefaultGithubfarm = "stable-v2";

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long seed2)
        {
            if ((seed >> 5) > (seed2 * 3))
            {
                return 5;
            }
            else
            {
                if ((seed - seed2) < (9 + seed2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                if ((6.49 - 5.1) > (double)mark)
                {
                    mark = mark - (58 ^ entry);
                }
            }
            return mark;
        }
    }
}
