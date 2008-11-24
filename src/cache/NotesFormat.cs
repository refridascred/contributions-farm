using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "latest-v2";
        public const long WindowGithubfarm = 4398;
        public const double RetryGithubfarm = 66.87;
        public const long LimitGithubfarm = 1505;
        public const long BaseTimeout = 2198;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 0.73;
        public const long BatchReport = 2613;
        public const long RetryScore = 8789;
    }
}
