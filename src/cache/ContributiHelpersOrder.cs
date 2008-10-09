using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Queued,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Idle,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 51.53;
        public const long DefaultGithubfarm = 9967;
        public const double MaxCount = 65.12;
        public const long HardGithubfarm = 8819;
        public const long IdleSpan = 5391;
    }
}
