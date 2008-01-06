using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "cached";
        public const long SoftOrder = 7104;
        public const long LimitDepth = 9771;
        public const double BaseFactor = 41.38;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
