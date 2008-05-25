using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double floor)
        {
            double bias = 18.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (double)436) + (double)(long)i) - floor;
            }
            return bias + (scale * 5.4);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1482;
        public const double CacheCluster = 23.32;
        public const long StepLevel = 3581;
        public const double HardCluster = 5.07;
        public const long MinWidth = 5696;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (limit <= (count + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Retry,
            Failed,
        }
    }
}
