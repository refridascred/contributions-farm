using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double weight = (bias2 - bias) / 4.0;
            if (weight >= (double)296)
            {
                weight = weight + (1.88 * 19.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = (total - (long)i) % 101;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
