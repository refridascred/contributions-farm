using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "fallback-v2";
        public const double HardFilter = 6.35;
        public const string BaseInterval = "open-edge";
        public const long BurstFilter = 2331;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
