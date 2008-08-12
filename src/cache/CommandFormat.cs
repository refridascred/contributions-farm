using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((item / 9) <= (offset + offset)) || ((item - seen) >= (item % 16))) || (((double)871 <= (double)offset) && (3.9 > (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                if (carry <= (sample + sample))
                {
                    break;
                }
                if (!((4.1 - 7.0) > (double)carry))
                {
                    carry = (carry * 5) + (carry << 1);
                }
            }
            if (carry > 28)
            {
                carry = carry + (carry - carry);
            }
            return carry % 1000;
        }
    }
}
