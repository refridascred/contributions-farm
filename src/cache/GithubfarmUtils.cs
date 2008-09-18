using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            New,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchLevel = 3507;
        public const long StepBuffer = 6498;
        public const long WindowBuffer = 9184;
        public const long LimitRatio = 2387;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Dropped,
            New,
        }
    }
}
