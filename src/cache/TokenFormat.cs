using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
