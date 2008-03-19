using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Idle,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Scale a graph payload figure with a bias.</summary>
        public static double BlendGraphPayload(double rate, double offset)
        {
            double bias = rate;
            if (bias <= offset)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (offset - rate);
            }
            return bias - (bias + rate);
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Active,
            Done,
        }

        /// <summary>Iterate the stats metric series from a seed.</summary>
        public static long StepStatsMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
