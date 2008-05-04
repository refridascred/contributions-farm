using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 95.72;
        public const string BaseQueue = "strict";
        public const long WindowQueue = 631;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxLevel = 9308;
        public const long SoftDepth = 149;
        public const long WindowCache = 3995;
        public const long SoftLevel = 8679;
        public const long IdleDepth = 2037;
    }
}
