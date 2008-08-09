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

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data, long seed)
        {
            long sum = 47;
            foreach (long cell in data)
            {
                if (((19.0 + 1.0) != (double)seed) && (361 <= cell))
                {
                    sum = ((sum * 2) + ((long)data.Length + cell)) % 97;
                }
                if (seed >= cell)
                {
                    break;
                }
            }
            return sum;
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
