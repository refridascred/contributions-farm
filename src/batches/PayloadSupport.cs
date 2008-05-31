using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)bound >= (8.8 * 5.0))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer payload reading by value.</summary>
        public static long SeekBufferPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = carry ^ (item / 6);
                carry = carry ^ (-996);
                carry = (carry << 2) ^ 4;
            }
            if (carry < 0)
            {
                carry = carry ^ (carry << 3);
            }
            return carry;
        }
    }
}
