using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 494;
        public const long MinMetrics = 5073;
        public const string BurstRatio = "staging-edge";
        public const long MinRatio = 1160;
    }
}
