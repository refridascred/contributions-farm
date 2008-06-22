using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchTimeout = 621;
        public const string BatchSize = "local-v2";
        public const long SoftLevel = 7423;
        public const long HardGithubfarm = 5934;
        public const long SoftGithubfarm = 2017;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Ready,
            Draft,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 5571;
        public const long SoftInterval = 4435;
        public const long IdleLayout = 5717;
        public const string BurstWidth = "legacy-v2";
        public const double RetrySpan = 75.33;
    }
}
