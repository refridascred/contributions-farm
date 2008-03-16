using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 1844;
        public const long MinRoute = 5800;
        public const string SoftRoute = "staging-edge";
        public const long MinBudget = 961;
        public const long RetryRatio = 8967;

        /// <summary>Audit format token readings against a rule.</summary>
        public static long MeasureFormatTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count == (4.16 + 8.49))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum + seed) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
