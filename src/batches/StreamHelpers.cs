using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Active,
            New,
            Queued,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 3052;
        public const long SoftQueue = 745;
        public const long StepDepth = 7342;
        public const long StepLevel = 8213;

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinFactor = "alpha-edge";
        public const double BatchSpan = 22.75;
        public const long BatchGraph = 7965;
        public const long CacheGraph = 2944;
        public const long MinGraph = 6187;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
