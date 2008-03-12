using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleDepth = "strict-1";
        public const long WindowWidth = 2446;
        public const long IdleEditor = 3036;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Retry,
            Closed,
            Active,
            Ready,
        }
    }
}
