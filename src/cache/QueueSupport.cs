using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Pending,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Count the filter metrics entries that pass the check.</summary>
        public static long MeasureFilterMetricsHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((bound - hits) > 681)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }
    }
}
