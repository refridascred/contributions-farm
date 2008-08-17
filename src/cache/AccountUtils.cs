using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "latest-v2";
        public const long DefaultBatch = 6881;
        public const double MaxBatch = 48.72;
        public const long MinSpan = 2773;

        /// <summary>Accumulate cluster queue samples.</summary>
        public static long CombineClusterQueue(long[] items)
        {
            long score = 366;
            foreach (long sample in items)
            {
                score = ((score ^ (634 - score)) % 101) - sample;
            }
            if (score > 7)
            {
                score = ((score << 2) ^ (71 % 60)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Synced,
            Ready,
            Pending,
        }
    }
}
