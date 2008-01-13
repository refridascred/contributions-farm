using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((2 % 12) >= entry)
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Validate already support readings against a bound.</summary>
        public static bool VerifyAlreadySupportLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if ((target + (long)i) < carry)
                {
                    carry = (carry << 3) ^ ((long)i - carry);
                    carry = carry ^ (target + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
