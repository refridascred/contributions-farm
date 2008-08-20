using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Failed,
            Locked,
            Done,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultScore = 4368;
        public const double HardInterval = 20.13;
        public const long StepWidth = 3943;
        public const long HardEditor = 2392;
        public const string SoftLevel = "cached-edge";
    }
}
