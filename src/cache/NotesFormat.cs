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

        /// <summary>Digest a series of checks stream entries.</summary>
        public static long ScoreChecksStream(long[] levels, long bound)
        {
            long result = -229;
            foreach (long value in levels)
            {
                if (value < (bound & 31))
                {
                    result = (result - (result >> 2)) % 101;
                }
            }
            if (result < (-8))
            {
                result = (result ^ (result * 3)) % 97;
            }
            return result % 1000;
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
