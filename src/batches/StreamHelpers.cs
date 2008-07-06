using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((hits - hits) >= (hits * 4)) || ((3.6 * 17.0) >= (double)hits)) || ((0 + hits) == (entry ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)sum != (3.74 - 3.61))
                {
                    sum = sum ^ (sum + sum);
                    sum = ((sum << 2) ^ (sum & 31)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }
    }
}
