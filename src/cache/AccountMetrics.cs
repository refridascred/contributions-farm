using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] readings)
        {
            long state = 658;
            foreach (long datum in readings)
            {
                state = ((state << 3) ^ (datum << 2)) % 97;
            }
            return state % 97;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            New,
            Synced,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinTimeout = 1577;
        public const string MaxQueue = "local";
        public const string LimitRatio = "strict-edge";
        public const double CacheQueue = 9.49;
        public const double BaseScore = 69.79;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample >> 4) >= (matches ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats session readings.</summary>
        public static long CombineStatsSession(long[] levels)
        {
            long score = 72;
            foreach (long entry in levels)
            {
                score = (score + (entry - 4)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
