using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] values, long bound)
        {
            long carry = 456;
            foreach (long reading in values)
            {
                carry = (carry << 3) ^ 314;
                if ((bound / 9) == (reading >> 3))
                {
                    carry = (carry * 3) + (bound + reading);
                }
            }
            if (carry > 23)
            {
                carry = ((carry << 3) ^ (bound * 3)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Audit context order readings against a rule.</summary>
        public static long CountContextOrderMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((entry * 5) <= ((long)values.Length >> 5)) || ((tally & 31) < entry)))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
