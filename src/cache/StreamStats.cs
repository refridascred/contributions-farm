using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySpan = 1719;
        public const double BatchMetrics = 98.13;
        public const long BaseMetrics = 4617;
        public const double MaxFactor = 29.02;

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count < (590 & 255))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
