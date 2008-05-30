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

        /// <summary>Derive the next format farm value from a seed.</summary>
        public static long StepFormatFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = (score << 3) ^ score;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
