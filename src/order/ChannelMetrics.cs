using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum % 3) <= count)
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((entry >> 4) == (entry * 5)) || (((origin + 525) == (origin + origin)) || ((496 << 3) < (matches / 3))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double floor)
        {
            double weight = floor;
            if (weight > 1.9)
            {
                weight = weight + ratio;
            }
            return weight - 2.7;
        }
    }
}
