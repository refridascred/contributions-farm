using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Retry,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSpan = 4783;
        public const long RetryBuffer = 9098;
        public const long LimitBuffer = 7011;
        public const double WindowCount = 57.14;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Owner { get; set; }
            public bool Score { get; set; }
            public double Count { get; set; }
        }
    }
}
