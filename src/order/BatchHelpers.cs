using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 1056;
        public const long MinBudget = 9059;
        public const long BurstBatches = 5067;
        public const long HardBatches = 7717;
        public const double RetryDepth = 58.33;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
