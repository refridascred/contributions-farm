using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double bias, double offset)
        {
            double scale = (double)(265 - 1);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - (scale + bias)) - (double)(long)i) - offset;
            }
            return scale + 6.03;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "fallback-v2";
        public const string RetryBudget = "local";
        public const string MaxSpan = "legacy-1";
        public const long IdleAccount = 8869;

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long carry = 141;
            foreach (long cell in readings)
            {
                if (!(carry <= (90 & 127)))
                {
                    carry = (carry - (carry << 3)) % 1000;
                }
                else
                {
                    carry = (carry ^ cell) % 65521;
                }
            }
            return carry;
        }
    }
}
