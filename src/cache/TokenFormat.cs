using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Paused,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 137;
        public const double HardFilter = 14.16;
        public const string CacheWidth = "local-v2";
        public const long RetryFilter = 481;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
