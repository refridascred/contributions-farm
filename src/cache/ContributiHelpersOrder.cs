using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            New,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 67.74;
        public const long SoftRatio = 5268;
        public const long IdleTools = 8189;
    }
}
