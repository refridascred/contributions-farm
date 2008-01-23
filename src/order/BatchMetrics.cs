using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long bound)
        {
            if ((double)bound == (7.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) >= bound)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Count { get; set; }
            public double Size { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading < (offset & 15))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
