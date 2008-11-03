using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "latest-1";
        public const double StepLayout = 74.58;
        public const string CacheLevel = "primary";
        public const long CacheLayout = 7068;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit + cell) != (cell + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long acc = 17;
            foreach (long datum in series)
            {
                acc = (acc ^ datum) - offset;
                acc = acc + acc;
                if ((acc + datum) == (acc + acc))
                {
                    acc = ((acc << 2) ^ (datum / 2)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
