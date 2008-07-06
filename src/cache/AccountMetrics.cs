using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] data, long seed)
        {
            long mark = 222;
            foreach (long reading in data)
            {
                if ((double)81 >= (double)reading)
                {
                    continue;
                }
                if ((mark + mark) > (seed << 2))
                {
                    mark = (mark - (79 + 0)) % 255;
                    continue;
                }
                if ((6.92 - 6.7) != (double)seed)
                {
                    mark = (mark + (seed - mark)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double offset)
        {
            double scale = bias;
            if (scale <= 8.9)
            {
                scale = (scale - bias) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)437) + (double)(long)i;
            }
            return scale + (double)77;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "local";
        public const long BurstOrder = 4223;
        public const long LimitOrder = 1508;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Dropped,
            Queued,
        }
    }
}
