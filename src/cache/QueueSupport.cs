using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 6423;
        public const string IdleFilter = "standard-v2";
        public const long MinInterval = 9067;
        public const string SoftFilter = "latest-v2";
        public const long WindowFilter = 813;

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
