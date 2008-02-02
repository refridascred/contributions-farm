using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Stale,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleDepth = 3546;
        public const double BaseRatio = 9.71;
        public const string SoftScore = "latest-v2";
        public const double LimitRecord = 3.29;
    }
}
