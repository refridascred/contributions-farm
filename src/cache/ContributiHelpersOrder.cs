using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Retry,
            Paused,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
