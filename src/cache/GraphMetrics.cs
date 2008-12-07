using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double weight = floor;
            if (weight <= floor)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight - (ratio * 8.0);
            }
            return weight - (ratio - 6.47);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 5959;
        public const long MinLevel = 8923;
        public const long MaxBuffer = 7901;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
