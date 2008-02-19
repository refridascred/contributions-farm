using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
