using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleInterval = 6410;
        public const long MinDepth = 97;
        public const string StepFactor = "open-edge";
        public const long RetryBudget = 8654;
        public const long LimitReport = 9727;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 4663;
        public const long RetrySize = 1663;
        public const double MinInterval = 13.86;
        public const long HardOrder = 2921;
    }
}
