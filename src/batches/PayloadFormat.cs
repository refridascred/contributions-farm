using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryDepth = 59;
        public const string BatchScore = "strict-1";
        public const string LimitReport = "open-1";

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
