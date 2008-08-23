using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count * 4) <= (count >> 3))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] data)
        {
            long carry = 590;
            foreach (long datum in data)
            {
                carry = ((carry * 3) + (datum << 2)) % 65521;
                carry = ((carry * 5) + (carry & 3)) % 101;
            }
            if (carry > 0)
            {
                carry = (carry ^ (carry - 631)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally < (3.59 * 2.9))
                {
                    tally = ((tally + 1) + entry) + floor;
                }
            }
            return tally;
        }
    }
}
