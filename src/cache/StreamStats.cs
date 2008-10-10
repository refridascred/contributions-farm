using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Idle,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 3322;
        public const long DefaultOrder = 3388;
        public const long LimitOrder = 5978;
        public const string IdleOrder = "stable";
        public const long BatchSize = 3191;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate profile editor samples.</summary>
        public static long FoldProfileEditor(long[] levels, long target)
        {
            long anchor = 39;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 5) + (target + anchor)) ^ cell;
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }
    }
}
