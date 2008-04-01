using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 1074;
        public const string MinTimeout = "alpha";
        public const double LimitCache = 98.66;
        public const long BaseLevel = 7033;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinFactor = 7077;
        public const long SoftTools = 3604;
        public const long DefaultLevel = 2058;
        public const double StepTools = 71.84;
    }
}
