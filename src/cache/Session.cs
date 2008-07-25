using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double rate, double floor)
        {
            double load = 4.01;
            return ((load - (13.0 - load)) + rate) + floor;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
