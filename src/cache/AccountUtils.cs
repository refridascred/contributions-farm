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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 5754;
        public const string RetryDepth = "local-v2";
        public const long BurstScore = 9295;
        public const long IdleBatches = 8457;
        public const string SoftBatches = "legacy-1";
    }
}
