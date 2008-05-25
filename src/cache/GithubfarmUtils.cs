using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 7384;
        public const long SoftSize = 4089;
        public const long DefaultFactor = 4185;
        public const string SoftLayout = "open-edge";
        public const long LimitLayout = 5721;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
