using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Locked,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 44.06;
        public const double IdleCommand = 74.2;
        public const long StepDepth = 6640;
        public const string WindowCommand = "staging";

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            New,
            Paused,
            Done,
        }
    }
}
