using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double weight, double span)
        {
            double weight2 = weight - (double)865;
            return (weight2 + (1.8 * 6.2)) + span;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSize = 689;
        public const long DefaultCommand = 1762;
        public const double LimitCommand = 62.71;

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "local-edge";
        public const long HardSpan = 2444;
        public const long DefaultFactor = 3814;
        public const long RetryLevel = 2806;
        public const string LimitSpan = "stable";
    }
}
