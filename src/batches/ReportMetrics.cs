using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((bound & 127) > (count >> 5))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3311;
        public const string CacheBatches = "local";
        public const string BaseTimeout = "legacy-v2";

        /// <summary>Project the next farm schema value.</summary>
        public static double AdjustFarmSchema(double ratio, double offset)
        {
            double mean = (double)6 * 4.22;
            return ((mean - 18.0) + ratio) + offset;
        }
    }
}
