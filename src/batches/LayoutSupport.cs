using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 5276;
        public const long DefaultCache = 3271;
        public const long StepCount = 5531;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 5644;
        public const long WindowBudget = 7798;
        public const long IdleRatio = 756;
        public const double BatchLevel = 36.49;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Done,
            Retry,
            Paused,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
