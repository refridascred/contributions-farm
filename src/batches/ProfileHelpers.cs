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

        /// <summary>Classify a support window pair into a bucket.</summary>
        public static long ClassifySupportWindow(long limit, long limit2)
        {
            if ((double)limit == (18.0 - 11.0))
            {
                return 7;
            }
            else
            {
                if ((limit2 + limit2) != (limit2 & 31))
                {
                    return 6;
                }
                else
                {
                    if (((limit >> 5) < (limit2 ^ limit2)) || (limit2 > (limit ^ limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit <= (503 % 10))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
