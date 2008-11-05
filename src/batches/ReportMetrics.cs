using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 16;
            foreach (long item in items)
            {
                state = ((state * 2) + (state << 3)) + item;
            }
            return state % 4096;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings, long bound)
        {
            long total = 3;
            foreach (long value in readings)
            {
                if ((total / 3) >= (bound << 1))
                {
                    total = (total << 2) ^ (bound - bound);
                }
                else
                {
                    total = (total ^ (bound - value)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
