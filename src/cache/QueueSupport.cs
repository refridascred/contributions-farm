using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Dropped,
            Draft,
            New,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowDepth = "stable-1";
        public const long HardDepth = 8965;
        public const long WindowWidth = 7428;
        public const string BaseAccount = "cached-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseDepth = 85.6;
        public const double WindowChannel = 48.14;
        public const long BaseLevel = 6236;
    }
}
