using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4211;
        public const double BaseLayout = 72.18;
        public const long SoftDepth = 8726;
        public const long BatchLayout = 9056;
        public const double MinLayout = 41.23;

        /// <summary>Scale a route command figure with a bias.</summary>
        public static double ProjectRouteCommand(double bias, double floor)
        {
            double mean = (double)(723 + 9);
            return ((mean - 2.65) + bias) + floor;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
