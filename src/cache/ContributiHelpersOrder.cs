using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Retry,
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 2057;
        public const long IdleWindow = 861;
        public const double BatchWindow = 70.37;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Queued,
            Paused,
            Pending,
            Done,
        }
    }
}
