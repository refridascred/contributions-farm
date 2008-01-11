using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinScore = 5493;
        public const long HardProfile = 1071;
        public const long BaseDepth = 2786;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "stable-edge";
        public const double WindowRatio = 81.22;
        public const string HardScore = "latest-edge";
        public const long StepRatio = 4338;
        public const string SoftMetrics = "alpha-edge";

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Synced,
            New,
            Done,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Ready,
            New,
            Pending,
            Paused,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
