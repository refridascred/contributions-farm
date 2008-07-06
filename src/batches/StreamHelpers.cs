using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchRatio = 8770;
        public const long RetryTimeout = 383;
        public const string HardMetrics = "fallback";

        /// <summary>Look up the position of a report stream sample.</summary>
        public static long FindReportStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 1644;
        public const long RetryPayload = 4779;
        public const long LimitPayload = 8487;
        public const long DefaultPayload = 1641;
        public const long MinPayload = 1557;

        /// <summary>Count the farm cache entries that pass the check.</summary>
        public static long MeasureFarmCacheGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (8 <= (long)series.Length)
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }
    }
}
