using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long offset)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                mix = (mix + (cell / 9)) - offset;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values)
        {
            long mark = 787;
            foreach (long entry in values)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark << 3) ^ (mark * 4)) + (long)i2;
                }
                if ((entry >> 3) > mark)
                {
                    mark = ((mark * 5) + (-23)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools stream entry that matches the target.</summary>
        public static long SeekToolsStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
