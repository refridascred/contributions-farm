using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 4510;
        public const long LimitPayload = 3306;
        public const long RetrySize = 81;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultInterval = 12.25;
        public const double RetryMetrics = 54.87;
        public const long IdleMetrics = 3263;
    }
}
