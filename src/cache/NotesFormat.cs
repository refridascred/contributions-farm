using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 6826;
        public const double WindowFormat = 62.39;
        public const long IdleFactor = 8246;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "staging-v2";
        public const double SoftFactor = 78.48;
        public const long MinCommits = 1851;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Retry,
            Stale,
        }
    }
}
