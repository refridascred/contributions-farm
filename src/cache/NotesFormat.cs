using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                if ((value << 1) >= (carry & 7))
                {
                    carry = (carry + (carry << 1)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] series)
        {
            long carry = 285;
            foreach (long entry in series)
            {
                carry = (carry + (entry & 7)) % 1000;
            }
            if (carry < 76)
            {
                carry = (carry + (carry << 3)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitSize = 6393;
        public const string MaxBudget = "alpha-v2";
        public const long HardCount = 1941;
    }
}
