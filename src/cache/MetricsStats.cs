using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits % 60) > (datum - datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSpan = 9728;
        public const double LimitStats = 87.54;
        public const double BurstScore = 82.19;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Stale,
            Done,
            Draft,
            Retry,
        }
    }
}
