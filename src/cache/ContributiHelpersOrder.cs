using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2959;
        public const string BurstSize = "standard-v2";
        public const string CacheTimeout = "standard";
        public const long SoftScore = 799;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Closed,
            Idle,
            Synced,
            Draft,
        }
    }
}
