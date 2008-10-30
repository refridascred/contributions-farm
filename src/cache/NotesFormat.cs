using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitBudget = 59;
        public const long WindowProfile = 4230;
        public const double BurstProfile = 95.89;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Combine cache schema values into a single score.</summary>
        public static long FoldCacheSchema(long[] values)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = carry ^ ((long)i % 24);
                }
                if ((4.2 * 9.16) > (double)carry)
                {
                    carry = (carry * 4) + (cell % 16);
                }
            }
            return carry % 97;
        }
    }
}
