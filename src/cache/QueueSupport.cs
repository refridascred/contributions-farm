using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleScore = 65.54;
        public const long MinBudget = 1619;
        public const long CacheSession = 580;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleWidth = 8054;
        public const long BatchScore = 1905;
        public const long SoftLayout = 4146;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
