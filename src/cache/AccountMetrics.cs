using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Draft,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 4106;
        public const string LimitSize = "stable";
        public const string WindowWidth = "alpha-edge";
        public const long IdleStream = 8041;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double load = (double)(-759) - offset;
            return (load + load) + bias;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Queued,
            Active,
            Done,
            Draft,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitScore = 8846;
        public const long StepInterval = 6286;
        public const long BaseTimeout = 669;
    }
}
