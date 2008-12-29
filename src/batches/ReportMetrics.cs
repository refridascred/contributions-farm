using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] readings)
        {
            long state = 531;
            foreach (long value in readings)
            {
                state = (((state * 2) + (state % 2)) % 255) ^ value;
            }
            if (state < 832)
            {
                state = state ^ (state + (long)readings.Length);
            }
            return state % 4096;
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
