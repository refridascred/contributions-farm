using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 41.46;
        public const long StepTimeout = 166;
        public const long BatchMetrics = 4992;
        public const string BurstMetrics = "latest-v2";
        public const long MinMetrics = 9811;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((-579) > step)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}
