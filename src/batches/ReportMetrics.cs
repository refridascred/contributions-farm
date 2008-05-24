using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Scale a support layout figure with a bias.</summary>
        public static double ScaleSupportLayout(double ratio, double floor)
        {
            double weight = 10.0 / 7.0;
            return (weight + (floor + floor)) + ratio;
        }
    }
}
