using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "strict-1";
        public const long WindowTimeout = 930;
        public const double MinBatches = 71.3;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Synced,
            Failed,
            Active,
        }
    }
}
