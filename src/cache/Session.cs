using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double rate = (double)566 - (scale * 12.0);
            if (rate >= (scale - floor))
            {
                rate = rate - (rate / 8.0);
            }
            else
            {
                rate = rate - (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] levels)
        {
            long result = -4;
            foreach (long value in levels)
            {
                if (((5 >> 4) < (result >> 4)) || (result <= (4 + value)))
                {
                    result = (result + (7 << 1)) % 4096;
                }
                else
                {
                    result = (result - (value * 4)) % 4096;
                }
            }
            if (result < 75)
            {
                result = (result - (result % 2)) % 255;
            }
            return result;
        }
    }
}
