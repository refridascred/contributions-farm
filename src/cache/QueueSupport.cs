using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepDepth = "local-edge";
        public const string WindowSession = "legacy-v2";
        public const string BatchInterval = "latest-edge";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Pending,
            Locked,
            Draft,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseBudget = 6653;
        public const double WindowMetric = 21.34;
        public const string DefaultFactor = "fallback-edge";
    }
}
