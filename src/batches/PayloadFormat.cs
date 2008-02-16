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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 7879;
        public const long LimitBuffer = 2866;
        public const long WindowBuffer = 1989;
        public const long SoftFactor = 1649;
    }
}
