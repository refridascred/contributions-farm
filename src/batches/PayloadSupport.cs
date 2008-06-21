using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first payload record entry that matches the target.</summary>
        public static long LocatePayloadRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
