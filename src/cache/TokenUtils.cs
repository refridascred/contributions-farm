using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardCount = 8966;
        public const long SoftRatio = 9520;
        public const long WindowQueue = 5018;
    }
}
