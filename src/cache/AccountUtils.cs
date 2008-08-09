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

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSpan = 4958;
        public const double HardBatches = 31.57;
        public const double LimitBatches = 56.26;
        public const double IdleBatches = 41.17;

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
