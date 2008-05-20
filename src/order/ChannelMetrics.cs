using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels)
        {
            long mark = 638;
            foreach (long cell in levels)
            {
                mark = (mark - (mark * 5)) % 4096;
                if ((double)mark == (8.0 + 20.0))
                {
                    mark = mark - 410;
                    mark = (mark * 4) + (-199);
                }
                if ((21 * 4) == (mark - (-981)))
                {
                    mark = (mark - (mark & 255)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (cell << 1)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
