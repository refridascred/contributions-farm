using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long origin)
        {
            long result = 5;
            foreach (long cell in values)
            {
                result = (((result ^ (405 >> 2)) % 97) ^ cell) + origin;
            }
            return result % 1000;
        }

        /// <summary>Scale a buffer order figure with a bias.</summary>
        public static double AdjustBufferOrder(double scale, double floor)
        {
            double load = (double)(98 << 1);
            return ((load - (double)0) + scale) + floor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + target;
                acc = (acc + acc) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
