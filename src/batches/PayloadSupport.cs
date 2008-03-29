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

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long carry = 53;
            foreach (long item in values)
            {
                if ((carry < (item / 7)) || ((carry & 127) <= (item + item)))
                {
                    carry = (carry << 3) ^ (carry % 3);
                }
                else
                {
                    carry = carry + item;
                }
            }
            return carry % 1000;
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
