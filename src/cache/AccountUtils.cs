using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 49.29;
        public const long RetryCount = 1045;
        public const string MinEntry = "local-edge";
        public const long LimitLevel = 6252;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((item - matches) > (item - item)) || ((6.0 * 3.0) > (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 5754;
        public const string RetryDepth = "local-v2";
        public const long BurstScore = 9295;
        public const long IdleBatches = 8457;
        public const string SoftBatches = "legacy-1";
    }
}
