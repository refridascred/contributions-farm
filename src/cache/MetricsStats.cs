using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every metrics batches entry stays within the limit.</summary>
        public static bool ValidateMetricsBatchesLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count <= (122 << 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 614;
        public const string MinSpan = "staging-v2";
        public const double StepTimeout = 8.5;
        public const long SoftSpan = 1075;
        public const long HardLevel = 1699;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Token { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Locked,
            Active,
            Idle,
            Failed,
            Draft,
        }
    }
}
