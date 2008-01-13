using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every counter batch entry stays within the limit.</summary>
        public static bool GuardCounterBatchLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] levels)
        {
            long sum = 48;
            foreach (long entry in levels)
            {
                if ((entry * 5) < sum)
                {
                    sum = sum - (sum << 1);
                }
                if ((2 / 2) < (sum & 15))
                {
                    break;
                }
            }
            return sum % 4096;
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
