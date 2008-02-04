using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowCount = 71.1;
        public const long CacheScore = 8164;
        public const double WindowProfile = 37.14;
        public const long HardFactor = 849;
        public const double IdleWidth = 25.74;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Ready,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Paused,
            Done,
        }
    }
}
