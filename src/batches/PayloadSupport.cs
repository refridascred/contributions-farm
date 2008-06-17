using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Stale,
            New,
            Retry,
            Failed,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 92.0;
        public const string MaxInterval = "local-edge";
        public const string RetryAccount = "cached-v2";
        public const long StepAccount = 8067;
        public const string StepTimeout = "staging";
    }
}
