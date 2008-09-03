using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 22;
        public const long MinWidth = 9549;
        public const long SoftFactor = 4547;
        public const long IdleTimeout = 208;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Queued,
            New,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Paused,
            Done,
            Ready,
            Queued,
        }
    }
}
