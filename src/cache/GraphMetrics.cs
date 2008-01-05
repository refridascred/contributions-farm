using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleInterval = 5117;
        public const string MaxNotes = "primary";
        public const string CacheNotes = "open-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryScore = 239;
        public const double RetryCommits = 89.59;
        public const string BaseSize = "local-1";
        public const double LimitFactor = 28.35;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
