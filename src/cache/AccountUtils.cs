using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate editor report samples.</summary>
        public static long CombineEditorReport(long[] levels, long limit)
        {
            long carry = 21;
            foreach (long cell in levels)
            {
                carry = (((carry + carry) % 65521) - cell) + limit;
            }
            if (carry > 251)
            {
                carry = ((carry << 3) ^ (carry ^ 96)) % 255;
            }
            return carry;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a command entry reading by value.</summary>
        public static long FindCommandEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
