using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit context filter readings against a rule.</summary>
        public static long AuditContextFilterMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!(hits < (hits - hits)))
                {
                    hits = ((hits + 1) - sample) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "primary-1";
        public const long RetryBuffer = 9438;
        public const long HardBuffer = 265;
        public const long HardSpan = 6217;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public double Label { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
