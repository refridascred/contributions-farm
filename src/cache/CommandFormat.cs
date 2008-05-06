using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Failed,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 5314;
        public const long MaxQueue = 6622;
        public const string HardQueue = "legacy-1";
        public const long CacheQueue = 6256;
        public const double HardSize = 48.51;
    }
}
