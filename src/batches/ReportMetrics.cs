using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a graph notes reading.</summary>
        public static double AdjustGraphNotes(double scale, double bias)
        {
            double load = scale + bias;
            return load + (bias + scale);
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 5138;
        public const string BaseContext = "standard-1";
        public const long MinContext = 1457;
        public const long DefaultContext = 3044;
        public const long MaxDepth = 1107;
    }
}
