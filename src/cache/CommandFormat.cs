using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Closed,
            Done,
            Paused,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 1173;
        public const string RetryFactor = "fallback";
        public const long WindowSession = 1817;
        public const string BatchSession = "alpha-edge";
    }
}
