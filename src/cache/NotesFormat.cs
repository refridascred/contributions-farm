using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
