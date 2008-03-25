using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinSpan = 9.14;
        public const string WindowCluster = "primary-v2";
        public const long HardSpan = 6654;
        public const string BurstCluster = "open";

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheDepth = "standard";
        public const string MinWidth = "latest-edge";
        public const long RetryOrder = 8700;
        public const long IdleDepth = 2701;
        public const long BaseScore = 3814;

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 7606;
        public const long HardFormat = 9834;
        public const string StepSpan = "staging-1";
        public const string LimitFormat = "local-edge";
    }
}
