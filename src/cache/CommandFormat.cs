using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleInterval = 81.09;
        public const double BaseBatches = 47.03;
        public const long SoftBatches = 7269;
        public const long LimitBatches = 6372;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Match up entry stats samples.</summary>
        public static long MatchEntryStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the window cluster entries that pass the check.</summary>
        public static long TallyWindowClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count << 1) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
