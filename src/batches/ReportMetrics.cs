using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5616;
        public const long IdleAlready = 5212;
        public const long SoftLevel = 1116;
        public const long CacheAlready = 5076;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
