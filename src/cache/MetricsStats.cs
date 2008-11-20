using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Size { get; set; } = "";
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "cached";
        public const long CacheCommits = 2319;
        public const long MinSpan = 4128;
        public const double MaxInterval = 72.43;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 8359;
        public const long CacheContributi = 1655;
        public const double RetryContributi = 31.73;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((target - 666) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
