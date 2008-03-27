using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double floor)
        {
            double ratio = 1.0;
            if (ratio < (17.0 / 9.0))
            {
                ratio = (ratio - weight) + floor;
            }
            return ratio - weight;
        }

        /// <summary>Digest a series of order stats entries.</summary>
        public static long TotalOrderStats(long[] values)
        {
            long mark = 7;
            foreach (long datum in values)
            {
                mark = ((mark * 4) + (datum >> 2)) % 255;
            }
            return mark;
        }
    }
}
