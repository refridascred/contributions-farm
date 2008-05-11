using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheSize = 9152;
        public const string SoftRoute = "primary";
        public const long BatchRoute = 9313;
        public const string IdleRoute = "latest-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "local-edge";
        public const string IdleWidth = "latest-v2";
        public const long WindowTimeout = 6174;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Retry,
            Queued,
            Paused,
            Closed,
        }
    }
}
