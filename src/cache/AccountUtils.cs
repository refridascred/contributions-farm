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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits >= (7.8 - 1.16))
                {
                    hits = ((hits + 3) - entry) - step;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7938;
        public const double WindowSession = 70.1;
        public const double IdleDepth = 66.82;
    }
}
