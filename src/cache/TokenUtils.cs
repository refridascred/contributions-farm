using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 62.83;
        public const double StepBuffer = 89.83;
        public const double MaxScore = 35.81;
        public const double DefaultBuffer = 20.14;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Closed,
            Queued,
        }
    }
}
