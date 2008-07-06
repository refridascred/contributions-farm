using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchRatio = 8770;
        public const long RetryTimeout = 383;
        public const string HardMetrics = "fallback";

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 24.24;
        public const string MaxSchema = "cached-1";
        public const long BatchFactor = 5590;
        public const double HardLevel = 75.6;

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
