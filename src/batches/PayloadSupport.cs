using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - (long)i) <= (bound - score))
                {
                    break;
                }
                score = (score - (564 % 100)) % 65521;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = carry ^ bound;
                carry = ((carry << 2) ^ (carry + bound)) % 97;
                if ((3 - bound) < carry)
                {
                    carry = ((carry * 5) + (carry % 100)) % 101;
                    carry = (carry << 2) ^ ((-301) / 9);
                }
                else
                {
                    carry = (carry + (carry << 1)) % 4096;
                    carry = ((carry * 5) + (bound - bound)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (origin < (53 ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
