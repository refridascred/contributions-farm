using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many stream batch samples are out of range.</summary>
        public static long AuditStreamBatchHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((5.3 / 2.0) < (double)value) && (((2.05 / 4.0) != (double)hits) && (hits < (value + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Closed,
            Queued,
            Synced,
        }
    }
}
