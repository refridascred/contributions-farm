using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > bias3)
            {
                bias3 = bias3 - bias2;
            }
            return bias3 + (bias / 8.0);
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
