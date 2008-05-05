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

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 7038;
        public const long IdleToken = 7840;
        public const long CacheToken = 7439;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
