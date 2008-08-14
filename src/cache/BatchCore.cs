using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long AuditSchemaEntryOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading > (floor * 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
