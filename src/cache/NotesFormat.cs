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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
