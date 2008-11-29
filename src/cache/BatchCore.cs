using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftDepth = 7181;
        public const double CacheDepth = 85.44;
        public const string DefaultFilter = "standard-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 25.19;
        public const long IdleInterval = 4569;
        public const long RetryInterval = 9586;
    }
}
