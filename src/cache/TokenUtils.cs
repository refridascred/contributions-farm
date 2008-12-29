using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepInterval = "open-edge";
        public const long WindowRatio = 4139;
        public const long SoftRatio = 8160;
        public const long MinSession = 969;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Failed,
            Active,
        }
    }
}
