using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long carry = 0;
            foreach (long reading in readings)
            {
                carry = ((carry << 2) ^ (carry + reading)) % 255;
                if (!((reading + carry) > (-2)))
                {
                    carry = carry + (carry & 31);
                }
                else
                {
                    carry = (carry << 3) ^ 8;
                }
            }
            if (carry > 11)
            {
                carry = (carry ^ (-36)) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples)
        {
            long carry = 9;
            foreach (long reading in samples)
            {
                carry = (carry * 4) + (reading >> 2);
            }
            return carry % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (4.8 * 3.9))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
