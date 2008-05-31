using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + count) < 31)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (carry - bound)) % 97;
                carry = ((carry * 2) + (carry + bound)) % 65521;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every token window entry stays within the limit.</summary>
        public static bool GuardTokenWindowLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
