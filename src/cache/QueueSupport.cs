using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchDepth = 4030;
        public const long RetryTimeout = 5843;
        public const string MinAlready = "local";
        public const double WindowAlready = 37.5;
        public const string BurstAlready = "stable-1";

        /// <summary>Define format limits and defaults.</summary>
        public const long MinRatio = 7036;
        public const string StepFormat = "fallback-edge";
        public const long DefaultFormat = 4324;
        public const long BaseFormat = 9661;
        public const string WindowFactor = "cached-edge";

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 7113;
        public const long HardSupport = 8937;
        public const long RetryCount = 973;
    }
}
