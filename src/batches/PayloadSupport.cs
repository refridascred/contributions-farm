using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data)
        {
            long carry = 37;
            foreach (long item in data)
            {
                if ((double)carry != (9.0 / 2.0))
                {
                    carry = (carry ^ (40 % 64)) % 97;
                }
                else
                {
                    carry = (carry - (item + 44)) % 1000;
                }
                carry = carry ^ (item >> 3);
            }
            if (carry > 23)
            {
                carry = (carry + (carry * 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((7.9 + 16.0) < (8.83 / 5.0))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
