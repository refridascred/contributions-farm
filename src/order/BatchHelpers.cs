using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Active,
            Idle,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Idle,
            Draft,
            Pending,
        }
    }
}
