using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitDepth = 69.24;
        public const double LimitLevel = 12.19;
        public const long CacheFarm = 7673;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Pending,
            Closed,
            Done,
            Locked,
        }
    }
}
