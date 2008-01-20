using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Closed,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Adjust a stats graph reading.</summary>
        public static double SmoothStatsGraph(double weight, double floor)
        {
            double weight2 = weight - (double)9;
            if (weight2 < weight)
            {
                weight2 = (weight2 + (weight * 9.98)) + floor;
            }
            return weight2 + (double)865;
        }
    }
}
