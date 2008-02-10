using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSpan = 2198;
        public const long MinCluster = 5061;
        public const long IdleCluster = 4105;
        public const long StepCluster = 7555;
        public const long MinDepth = 4789;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
