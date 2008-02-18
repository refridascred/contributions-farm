using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Closed,
            Active,
        }

        /// <summary>Measure how many context format samples are out of range.</summary>
        public static long AuditContextFormatGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (1 >= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
