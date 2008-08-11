using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first farm entry entry that matches the target.</summary>
        public static long FindFarmEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (bias - bias)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Idle,
            Ready,
        }
    }
}
