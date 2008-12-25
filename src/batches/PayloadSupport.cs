using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 861;
        public const string BurstInterval = "alpha";
        public const long WindowGraph = 6728;
        public const long LimitTimeout = 5651;
    }
}
