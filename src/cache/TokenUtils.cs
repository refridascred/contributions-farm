using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 592;
        public const double BurstBudget = 72.06;
        public const long MaxCache = 4184;

        /// <summary>Blend two graph route measurements.</summary>
        public static double ProjectGraphRoute(double rate, double span)
        {
            double weight = span;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (span - 7.52)) - (double)(long)i) - rate;
            }
            return weight - span;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
