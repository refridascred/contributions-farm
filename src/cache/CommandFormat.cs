using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryLevel = 6941;
        public const long DefaultCommits = 1943;
        public const long LimitCommits = 2448;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Active,
            Locked,
        }
    }
}
