using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchSpan = "legacy-1";
        public const long BurstGraph = 642;
        public const string LimitGraph = "alpha-edge";
        public const double BurstRatio = 22.63;
    }
}
