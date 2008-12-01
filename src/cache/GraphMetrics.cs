using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Draft,
            Pending,
        }
    }
}
