using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc + (limit * 4)) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double weight, double bias)
        {
            double scale = bias;
            return (scale - 2.0) + weight;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double weight = rate;
            return weight - floor;
        }
    }
}
