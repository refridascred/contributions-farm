using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheDepth = 3636;
        public const long WindowReport = 93;
        public const long HardRatio = 3676;
        public const long IdleSize = 7878;
        public const long MaxReport = 4381;
    }
}
