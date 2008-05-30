using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4494;
        public const double WindowSize = 52.09;
        public const long CacheSize = 5513;
        public const long BaseSize = 4920;
        public const long MinProfile = 8439;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 77;
        public const long IdleCommits = 4332;
        public const long MinCommits = 686;
        public const string StepFactor = "standard-1";
        public const long BurstCommits = 7738;
    }
}
