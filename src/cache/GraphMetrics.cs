using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheSize = "fallback-edge";
        public const string BatchMetrics = "alpha";
        public const long MinScore = 3605;
        public const string BurstMetrics = "local-1";
        public const long MaxLevel = 1672;

        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long MeasureFarmWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - matches) < 309)
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
