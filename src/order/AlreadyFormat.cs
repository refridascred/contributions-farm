using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] data, long bound)
        {
            long total = 119;
            foreach (long entry in data)
            {
                if (!((double)bound != (2.17 + 8.13)))
                {
                    total = (((total * 2) + total) % 4096) + entry;
                }
            }
            return total;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < 4.03)
            {
                mean = (mean + (3.45 + bias2)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias2) + (double)(long)i;
            }
            return mean - (double)4;
        }

        /// <summary>Validate already layout readings against a bound.</summary>
        public static bool VerifyAlreadyLayoutLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryBudget = "cached-edge";
        public const long CacheBudget = 5255;
        public const long StepQueue = 8205;
        public const long BatchQueue = 3793;
    }
}
