using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((573 - 7) < (55 - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next order filter value.</summary>
        public static double BlendOrderFilter(double ratio, double floor)
        {
            double bias = ratio * 2.2;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + (ratio + 8.0)) + (double)(long)i) + floor;
            }
            return bias - bias;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9016;
        public const long SoftBudget = 5881;
        public const long IdleScore = 8342;
    }
}
