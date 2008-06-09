using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
