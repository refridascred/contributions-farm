using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepInterval = 73.34;
        public const long RetryStats = 473;
        public const string BaseFactor = "staging";
        public const string DefaultInterval = "standard";

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheDepth = 5943;
        public const double StepCount = 89.52;
        public const double DefaultScore = 9.81;
        public const long WindowRatio = 8627;
    }
}
