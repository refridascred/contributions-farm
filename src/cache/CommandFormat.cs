using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitSpan = 86.6;
        public const double BaseEntry = 18.26;
        public const long SoftFactor = 3636;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 9942;
        public const long MaxTimeout = 9439;
        public const double MinSession = 28.69;
        public const double LimitTimeout = 44.19;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Pending,
            New,
        }
    }
}
