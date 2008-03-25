using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many graph cache samples are out of range.</summary>
        public static long AuditGraphCacheHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry - target) >= (entry + target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
