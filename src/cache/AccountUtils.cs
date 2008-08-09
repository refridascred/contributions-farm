using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count >> 5) > (item ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
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
