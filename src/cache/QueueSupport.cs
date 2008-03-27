using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxSpan = "open";
        public const long IdleBatch = 2458;
        public const string CacheBatch = "staging-edge";
        public const string CacheRatio = "local-edge";
        public const double MinRatio = 39.82;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }
    }
}
