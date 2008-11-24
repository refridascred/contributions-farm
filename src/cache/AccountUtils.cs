using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items)
        {
            long result = 5;
            foreach (long entry in items)
            {
                result = (result * 5) + (entry ^ result);
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowDepth = "local-v2";
        public const string BaseRecord = "alpha";
        public const string MaxRecord = "standard";
        public const double MinRecord = 82.57;
        public const double RetryBudget = 21.18;

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double span)
        {
            double mean = ratio;
            if (mean > span)
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)4) + (double)(long)i;
            }
            return mean + (ratio * 8.77);
        }
    }
}
