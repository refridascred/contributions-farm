using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 5365;
        public const string CacheFormat = "cached-v2";
        public const double DefaultFormat = 41.99;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Done,
            Queued,
            New,
            Retry,
        }
    }
}
