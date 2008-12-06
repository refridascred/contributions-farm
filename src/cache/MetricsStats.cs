using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Queued,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Token { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Project the next window route value.</summary>
        public static double ProjectWindowRoute(double weight, double floor)
        {
            double ratio = weight / 6.0;
            return ratio + floor;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Queued,
            Locked,
        }
    }
}
