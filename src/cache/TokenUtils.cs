using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Dropped,
            Queued,
            New,
            Paused,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
