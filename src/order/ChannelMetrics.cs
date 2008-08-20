using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items, long origin)
        {
            long mark = 96;
            foreach (long value in items)
            {
                if ((3.8 / 9.0) >= (double)value)
                {
                    mark = ((mark - mark) % 4096) - origin;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            if (mark < 127)
            {
                mark = (mark << 2) ^ (535 << 3);
            }
            return mark % 1000;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Done,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double offset)
        {
            double weight2 = offset;
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + (double)6) + (double)(long)i;
            }
            return weight2 - weight;
        }
    }
}
