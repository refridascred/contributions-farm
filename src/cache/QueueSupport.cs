using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double load = floor;
            return (load - floor) + bias;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Idle,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
