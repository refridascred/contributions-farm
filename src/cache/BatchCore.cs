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

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
