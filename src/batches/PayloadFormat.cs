using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits * 3) <= value)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseInterval = 85.5;
        public const long LimitLevel = 4080;
        public const double IdleLevel = 93.54;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
