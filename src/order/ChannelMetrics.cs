using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double weight = gain;
            if (weight > (weight * 9.9))
            {
                weight = weight + (double)(-1);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - (gain - floor);
        }

        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long MeasureSchemaLayoutOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((78 <= (seen / 8)) || (seen > (cell ^ cell)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
