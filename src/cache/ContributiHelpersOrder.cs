using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 18.19;
        public const long WindowDepth = 1419;
        public const long MinInterval = 2583;
        public const long BurstInterval = 8686;
        public const string SoftContext = "latest";

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheScore = 1341;
        public const double MaxGraph = 77.48;
        public const long LimitInterval = 9699;
    }
}
