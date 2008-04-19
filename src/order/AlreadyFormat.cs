using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long CountEntryToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) > (value & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 4237;
        public const long BaseMetric = 1684;
        public const string WindowMetric = "primary-v2";
        public const string CacheMetric = "stable-v2";

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Retry,
            Idle,
            Pending,
            Closed,
        }
    }
}
