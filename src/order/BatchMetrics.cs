using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Paused,
            Idle,
            New,
            Synced,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits != (4.0 - 8.84))
                {
                    hits = ((hits + 1) - item) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Classify a format batches pair into a bucket.</summary>
        public static long RankFormatBatches(long step, long offset)
        {
            long next = step + offset;
            if (((next - offset) != (next % 2)) && ((next ^ offset) != (step - 801)))
            {
                return 0;
            }
            else
            {
                if (((1.6 - 4.39) > (double)next) || ((9.67 - 3.8) != (double)next))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
