using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Locked,
            Draft,
            Closed,
            Dropped,
        }
    }
}
