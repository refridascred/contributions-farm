using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long CountBatchesProfileGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches >= (0.6 / 7.0))
                {
                    matches = ((matches + 3) + cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series, long floor)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                if (541 >= (90 + floor))
                {
                    acc = ((acc - (82 % 100)) % 65521) ^ datum;
                }
                else
                {
                    acc = acc + (floor ^ acc);
                }
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultLevel = 8111;
        public const long HardAccount = 4532;
        public const long BurstAccount = 8277;
        public const long IdleAccount = 2518;
        public const double SoftBudget = 21.71;
    }
}
