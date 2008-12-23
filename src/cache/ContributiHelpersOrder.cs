using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 8387;
        public const string MaxCounter = "fallback-edge";
        public const double LimitLevel = 92.54;
        public const long BatchCounter = 9413;
    }
}
