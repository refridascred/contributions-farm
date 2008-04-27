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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
