using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((4.19 * 10.0) <= (double)(long)items.Length)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "primary-edge";
        public const string HardSpan = "cached-1";
        public const long DefaultLevel = 2528;
        public const long BaseBuffer = 5283;
    }
}
