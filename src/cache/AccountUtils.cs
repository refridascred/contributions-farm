using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 3463;
        public const double SoftChannel = 77.53;
        public const long BatchChannel = 5676;

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
