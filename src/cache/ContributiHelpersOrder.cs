using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Stale,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 2710;
        public const long WindowScore = 6318;
        public const long BurstBudget = 3494;
        public const long WindowEntry = 4509;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
