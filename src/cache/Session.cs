using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
