using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (anchor + datum)) % 255;
                anchor = (anchor * 2) + (anchor ^ anchor);
                anchor = (anchor ^ (anchor / 5)) % 255;
            }
            if (anchor > 11)
            {
                anchor = (anchor - ((long)items.Length << 3)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((entry / 3) >= (count & 31)) || (((-5) - 303) >= offset)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
