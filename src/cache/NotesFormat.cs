using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            New,
            Stale,
            Retry,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels, long offset)
        {
            long sum = 9;
            foreach (long value in levels)
            {
                sum = (sum ^ ((-5) * 2)) ^ value;
                sum = (sum << 2) ^ (offset >> 4);
            }
            if (sum < 9)
            {
                sum = (sum + (sum + offset)) % 101;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "standard-edge";
        public const long HardLayout = 2076;
        public const long BatchBudget = 1723;
    }
}
