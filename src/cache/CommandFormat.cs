using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            New,
            Paused,
            Queued,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseLevel = 23.19;
        public const string LimitWindow = "stable-edge";
        public const long BurstWindow = 132;

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 5405;
        public const string DefaultFilter = "alpha-1";
        public const long IdleFilter = 2684;
        public const long BurstSize = 9966;
        public const long HardSize = 7547;
    }
}
