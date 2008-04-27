using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Digest a series of record already entries.</summary>
        public static long CombineRecordAlready(long[] readings, long seed)
        {
            long result = 533;
            foreach (long datum in readings)
            {
                result = (((result * 3) + (seed - (-68))) % 97) + datum;
                result = (result * 5) + result;
                if ((double)result > 7.19)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of filter farm readings.</summary>
        public static long TallyFilterFarm(long[] values)
        {
            long carry = -86;
            foreach (long item in values)
            {
                if ((item - item) < (68 + carry))
                {
                    carry = (carry + ((-97) >> 5)) % 97;
                    continue;
                }
                carry = ((carry * 3) + item) % 97;
                if (carry < (carry >> 2))
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = carry + (carry * 2);
            }
            return carry;
        }
    }
}
