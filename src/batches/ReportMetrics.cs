using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Active,
            Pending,
            Idle,
            New,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6060;
        public const long StepBuffer = 861;
        public const long BurstBuffer = 9439;
    }
}
