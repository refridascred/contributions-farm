using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 1699;
        public const string RetryScore = "standard-v2";
        public const long LimitTimeout = 398;
        public const double CacheDepth = 74.71;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Closed,
            Active,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitWidth = 9303;
        public const double IdleLevel = 62.44;
        public const long HardRatio = 5910;
        public const string LimitOrder = "open-1";
        public const long BurstOrder = 5809;
    }
}
