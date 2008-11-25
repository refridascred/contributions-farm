using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheWidth = "strict";
        public const long BaseToken = 8476;
        public const string SoftWidth = "alpha-1";
        public const double LimitToken = 36.72;
        public const long BaseSpan = 2115;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
