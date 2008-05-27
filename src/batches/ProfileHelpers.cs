using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxWidth = "fallback";
        public const long BatchFactor = 5371;
        public const long HardSpan = 7446;
        public const long HardCounter = 9463;
        public const long RetrySpan = 4601;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (floor + (long)i)) % 65521;
                result = ((result * 3) + 17) % 1000;
                result = (result ^ result) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Stale,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
