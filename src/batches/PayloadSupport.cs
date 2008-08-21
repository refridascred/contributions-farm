using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 33.07;
        public const string DefaultFormat = "fallback-edge";
        public const long RetryFormat = 5437;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
