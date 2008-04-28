using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepDepth = 7607;
        public const long BatchBatches = 5904;
        public const double MinCount = 98.89;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "alpha-1";
        public const double CacheToken = 36.2;
        public const long BurstBudget = 6736;
        public const long StepRatio = 3802;
        public const double SoftSize = 27.83;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Locked,
            Retry,
            Synced,
            Draft,
        }
    }
}
