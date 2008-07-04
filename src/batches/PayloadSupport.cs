using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Stale,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepFactor = 7429;
        public const string IdleStream = "latest-edge";
        public const long WindowStream = 3253;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 4596;
        public const long WindowEntry = 5879;
        public const double LimitEntry = 76.56;
        public const double MinEntry = 93.63;
        public const double RetryDepth = 41.69;
    }
}
