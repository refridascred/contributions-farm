using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 8714;
        public const long StepCount = 2877;
        public const long BurstTimeout = 8989;
        public const long MaxTimeout = 2200;
        public const long LimitSize = 7523;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
