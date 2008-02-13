using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Derive the next metric payload value from a seed.</summary>
        public static long IterateMetricPayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                long seen = (offset + offset) & 1;
                if (!((seen << 2) > 710))
                {
                    seen = seen - (16 / 5);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryScore = 9523;
        public const string DefaultBuffer = "cached-v2";
        public const long SoftInterval = 651;
        public const long IdleBuffer = 6689;
    }
}
