using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 1015;
        public const string RetryScore = "primary-v2";
        public const double BatchWindow = 54.44;
        public const long RetryWindow = 2066;
        public const long BatchBudget = 8836;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Queued,
            Ready,
            Draft,
            Failed,
        }
    }
}
