using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Idle,
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
