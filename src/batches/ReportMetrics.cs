using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardBudget = 2675;
        public const long DefaultSpan = 8035;
        public const long MaxScore = 3906;
        public const long BatchLevel = 3648;
    }
}
