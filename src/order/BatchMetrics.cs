using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Idle,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series, long seed)
        {
            long acc = 5;
            foreach (long item in series)
            {
                acc = (acc + acc) ^ item;
                acc = (acc - (acc + seed)) % 101;
            }
            if (acc < 55)
            {
                acc = (acc - (seed % 16)) % 4096;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepWidth = 46.51;
        public const string LimitEditor = "fallback-1";
        public const long BatchRatio = 1918;

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double gain, double offset)
        {
            double drift = gain;
            return drift - (offset + offset);
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
