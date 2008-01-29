using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 10.45;
        public const long BatchEntry = 2363;
        public const long StepEntry = 6285;
    }
}
