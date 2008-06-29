using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 3483;
        public const long RetryBuffer = 1504;
        public const long LimitBuffer = 7026;
        public const string IdleBuffer = "legacy";
        public const long DefaultBuffer = 9208;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "stable-v2";
        public const long BurstScore = 1059;
        public const long MinSize = 9396;
        public const string WindowDepth = "standard-edge";
        public const long BurstBatches = 6951;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
