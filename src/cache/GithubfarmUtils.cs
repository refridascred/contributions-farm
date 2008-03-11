using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a report cluster reading by value.</summary>
        public static long SeekReportClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Pending,
            Closed,
            Stale,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 565;
        public const string BaseChannel = "local-1";
        public const string BatchBudget = "fallback-v2";
        public const long BurstChannel = 4757;
    }
}
