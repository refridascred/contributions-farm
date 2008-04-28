using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((count % 10) > (count << 2)) || (((long)series.Length + count) == (count & 255)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double ratio = (scale / 2.0) / 5.0;
            if (ratio < (ratio / 7.0))
            {
                ratio = ratio - (floor - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
