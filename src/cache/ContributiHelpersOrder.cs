using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinTimeout = 9419;
        public const long RetryContext = 5758;
        public const long SoftDepth = 5293;
        public const double IdleContext = 30.94;

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 8.08;
        public const string MaxFactor = "open";
        public const long BurstRatio = 7459;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Queued,
            Dropped,
            Ready,
        }
    }
}
