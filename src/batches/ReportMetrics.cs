using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 1754;
        public const long BaseReport = 7429;
        public const double BatchSize = 33.76;
        public const double BatchRatio = 75.39;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long bound, long bound2)
        {
            if (!(bound > (bound / 3)))
            {
                return 7;
            }
            else
            {
                if ((bound % 24) != (bound / 5))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
