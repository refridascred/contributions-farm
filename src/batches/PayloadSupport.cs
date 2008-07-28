using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long TallyGraphSchemaGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 3) == (tally % 10))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + 6) > (bound / 8))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] samples, long floor)
        {
            long carry = 556;
            foreach (long value in samples)
            {
                if ((5 / 7) == (value + 0))
                {
                    carry = (((carry << 3) ^ (value % 16)) % 4096) + floor;
                }
            }
            if (carry < 705)
            {
                carry = (carry ^ (carry & 15)) % 4096;
            }
            return carry;
        }
    }
}
