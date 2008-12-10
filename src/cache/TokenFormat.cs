using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 2648;
        public const long MaxCounter = 4213;
        public const long WindowCounter = 1935;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long floor)
        {
            long acc = 113;
            foreach (long datum in readings)
            {
                acc = (acc << 2) ^ (datum % 64);
            }
            if (acc > 635)
            {
                acc = acc + (floor + floor);
            }
            return acc % 1000;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (bias - 6.8)) - (double)(long)i) + floor;
            }
            return ratio + bias;
        }
    }
}
