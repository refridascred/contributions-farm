using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6925;
        public const long StepCommits = 4271;
        public const long BaseCommits = 3343;
        public const long DefaultCount = 7738;
        public const double MaxCommits = 53.58;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Failed,
            Queued,
            Draft,
        }
    }
}
