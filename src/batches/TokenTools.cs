using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "local-1";
        public const string MinDepth = "local";
        public const double DefaultSpan = 73.52;
        public const long DefaultFactor = 9750;
        public const long DefaultGraph = 9220;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
