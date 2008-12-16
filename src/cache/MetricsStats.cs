using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            New,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseScore = 3344;
        public const string MinCommits = "primary-v2";
        public const long MaxCommits = 9335;
        public const long CacheCommits = 5674;
        public const long StepCommits = 480;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
