using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
