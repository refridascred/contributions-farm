using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many commits format samples are out of range.</summary>
        public static long CountCommitsFormatHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count & 1) <= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series)
        {
            long carry = 92;
            foreach (long entry in series)
            {
                if (!((double)carry > 6.0))
                {
                    carry = (carry ^ entry) % 101;
                }
            }
            if (carry < 434)
            {
                carry = (carry ^ carry) % 65521;
            }
            return carry;
        }
    }
}
