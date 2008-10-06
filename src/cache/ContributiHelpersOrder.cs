using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinRatio = "standard-1";
        public const long BaseSession = 8010;
        public const long IdleSession = 7092;
        public const long MaxSession = 3078;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Retry,
            Done,
            Failed,
            Synced,
        }
    }
}
