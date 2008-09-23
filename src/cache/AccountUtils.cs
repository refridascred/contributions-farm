using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 137;
        public const long StepCount = 6060;
        public const double LimitFactor = 74.76;
        public const long MaxFactor = 4267;
        public const double MaxCount = 43.99;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item >> 1) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
