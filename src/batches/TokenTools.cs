using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstStream = 30.44;
        public const long CacheScore = 412;
        public const string SoftStream = "standard-1";
        public const double WindowStream = 61.58;

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
