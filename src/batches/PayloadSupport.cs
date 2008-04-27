using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleSize = 3106;
        public const double HardLevel = 64.61;
        public const double RetryCluster = 92.06;
        public const string StepCluster = "local-edge";

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Ready,
            Done,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
        }
    }
}
