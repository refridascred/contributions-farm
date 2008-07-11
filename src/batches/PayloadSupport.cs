using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardSpan = 5319;
        public const string MaxCount = "open";
        public const long BatchInterval = 3055;
        public const long RetryAlready = 7601;
        public const string IdleAlready = "local-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 10.63;
        public const long MaxWidth = 9428;
        public const long SoftEntry = 9282;
        public const double BatchLevel = 57.97;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Queued,
            Locked,
            Synced,
            Idle,
        }
    }
}
