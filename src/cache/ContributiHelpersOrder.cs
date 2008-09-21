using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepFactor = 7998;
        public const long StepLayout = 6420;
        public const double BurstRatio = 46.76;
    }
}
