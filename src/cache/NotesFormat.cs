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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                long seen = sum;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (((sum << 2) ^ (85 << 2)) % 101) ^ (long)i2;
                    sum = ((sum * 4) + seen) % 101;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "standard-edge";
        public const long HardLayout = 2076;
        public const long BatchBudget = 1723;
    }
}
