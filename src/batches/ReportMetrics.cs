using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitWidth = 3306;
        public const long LimitContext = 7073;
        public const double DefaultContext = 40.48;
        public const long IdleLevel = 2022;

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
