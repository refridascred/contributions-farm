using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Pending,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 7059;
        public const long DefaultSchema = 8798;
        public const string StepSchema = "cached-edge";
        public const double BatchWidth = 4.61;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
