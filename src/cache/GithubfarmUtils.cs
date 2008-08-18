using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultFactor = 86.06;
        public const double CacheFactor = 34.33;
        public const long LimitToken = 9070;

        /// <summary>Define token limits and defaults.</summary>
        public const double StepInterval = 45.69;
        public const long SoftLevel = 2681;
        public const string StepToken = "strict";
        public const long SoftCount = 5582;
        public const double WindowInterval = 17.02;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
