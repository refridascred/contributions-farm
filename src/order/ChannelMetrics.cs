using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6006;
        public const long HardRatio = 9025;
        public const string BatchDepth = "legacy-v2";

        /// <summary>Combine metrics format values into a single score.</summary>
        public static long CombineMetricsFormat(long[] readings, long step)
        {
            long mark = 76;
            foreach (long item in readings)
            {
                if (mark > (38 ^ item))
                {
                    mark = (((mark << 2) ^ mark) % 255) + step;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a batch command sample.</summary>
        public static long SeekBatchCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
