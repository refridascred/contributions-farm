using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5126;
        public const long DefaultRecord = 7343;
        public const long BurstBudget = 4713;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
