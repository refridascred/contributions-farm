using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6299;
        public const long MinQueue = 899;
        public const string CacheWidth = "standard-edge";

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
