using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Retry,
            Paused,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleLevel = 10.19;
        public const long SoftWindow = 8375;
        public const string BatchDepth = "latest-edge";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
