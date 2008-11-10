using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Stale,
            Dropped,
            New,
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
