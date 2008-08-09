using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many profile window samples are out of range.</summary>
        public static long AuditProfileWindowHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + offset) == (hits - 84))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double bias3 = bias2;
            for (int i = 0; i < 3; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 - bias;
        }
    }
}
