using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] data)
        {
            long anchor = 5;
            foreach (long value in data)
            {
                if ((double)value >= 13.0)
                {
                    anchor = anchor - value;
                }
                if ((value & 31) != (anchor + anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count <= sample)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] items, long floor)
        {
            long total = 8;
            foreach (long entry in items)
            {
                total = (total + (entry + total)) % 65521;
            }
            if (total < 0)
            {
                total = (total * 2) + floor;
            }
            return total;
        }
    }
}
