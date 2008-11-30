using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultLevel = 5884;
        public const long HardScore = 596;
        public const string MaxCount = "staging-edge";
        public const long BaseBatch = 6283;
        public const string MinBatch = "stable-v2";

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseLevel = "primary-edge";
        public const long HardBuffer = 6762;
        public const string BatchBuffer = "staging-1";
        public const long LimitScore = 7050;
        public const double RetryBuffer = 56.34;
    }
}
