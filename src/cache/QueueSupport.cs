using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] items)
        {
            long sum = 98;
            foreach (long entry in items)
            {
                if ((sum % 3) >= (694 & 7))
                {
                    sum = (sum * 2) + (entry >> 4);
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long carry = 46;
            foreach (long reading in items)
            {
                if ((carry - carry) > (reading % 100))
                {
                    carry = (carry + (5 + 1)) % 97;
                }
                else
                {
                    carry = ((carry * 4) + (64 / 7)) % 1000;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 3) ^ 90;
            }
            return carry;
        }
    }
}
