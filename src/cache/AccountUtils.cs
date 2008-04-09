using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7938;
        public const double WindowSession = 70.1;
        public const double IdleDepth = 66.82;
    }
}
