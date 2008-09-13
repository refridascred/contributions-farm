using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Done,
            Queued,
            New,
            Ready,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 1) > 60)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
