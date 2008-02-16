using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Stale,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
