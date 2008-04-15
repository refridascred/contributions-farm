using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
