using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit context cache readings against a rule.</summary>
        public static long CountContextCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading < (reading & 31))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Failed,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 1958;
        public const long SoftToken = 1529;
        public const string LimitInterval = "staging-v2";
    }
}
