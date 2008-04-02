using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultLevel = "fallback-1";
        public const long LimitGraph = 270;
        public const string MaxGraph = "legacy-edge";
        public const double DefaultTimeout = 12.81;
        public const string DefaultFactor = "standard-v2";

        /// <summary>Blend two metric graph measurements.</summary>
        public static double BlendMetricGraph(double rate, double floor)
        {
            double weight = (rate * 17.0) + 14.0;
            if (weight <= (floor + floor))
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)669;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
