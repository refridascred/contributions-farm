using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > ratio)
            {
                ratio = (ratio + ratio) + floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + ratio)) - (double)(long)i;
            }
            return ratio + (ratio * 7.0);
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long floor)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                if (mark > floor)
                {
                    mark = ((mark * 3) + (item << 3)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (long)levels.Length) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Pending,
            Paused,
            Closed,
            Locked,
            Synced,
        }
    }
}
