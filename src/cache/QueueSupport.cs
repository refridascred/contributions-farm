using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryWidth = "fallback-v2";
        public const double MinSpan = 41.13;
        public const long LimitFarm = 2400;
        public const long MinFarm = 9996;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
