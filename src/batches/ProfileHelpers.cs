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

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
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
