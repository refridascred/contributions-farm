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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total + (total << 3);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
