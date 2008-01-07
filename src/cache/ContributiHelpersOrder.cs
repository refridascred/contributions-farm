using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 9791;
        public const long DefaultSpan = 8015;
        public const double IdleStats = 69.72;
        public const long IdleRatio = 316;
        public const double HardStats = 69.8;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            Stale,
            Idle,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Queued,
            Dropped,
            Active,
            New,
        }
    }
}
