using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Synced,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftInterval = 73.67;
        public const long BaseTools = 2140;
        public const long MinTools = 5988;
        public const double SoftTools = 42.54;
    }
}
