using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Retry,
            New,
            Failed,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double weight2 = 1.3;
            for (int i = 0; i < 6; i++)
            {
                weight2 = ((weight2 - (weight2 + offset)) + (double)(long)i) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Active,
            Synced,
            Ready,
        }
    }
}
