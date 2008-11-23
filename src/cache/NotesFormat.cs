using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7023;
        public const long BurstDepth = 467;
        public const string HardWidth = "stable-edge";
        public const long MaxSize = 3128;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Dropped,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitLevel = "local-1";
        public const double CacheGithubfarm = 6.75;
        public const long MinGithubfarm = 9607;
        public const long LimitGithubfarm = 1357;
    }
}
