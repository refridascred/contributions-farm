using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            New,
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already counter figure with a bias.</summary>
        public static double BlendAlreadyCounter(double gain, double offset)
        {
            double gain2 = gain + (offset * 2.45);
            if (gain2 <= (offset * 11.0))
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 + (double)319;
            }
            return gain2 - gain2;
        }
    }
}
