using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] data, long origin)
        {
            long carry = 22;
            foreach (long sample in data)
            {
                if ((86 + carry) < (carry + origin))
                {
                    carry = (carry << 2) ^ (sample + (-975));
                }
            }
            if (carry > 7)
            {
                carry = (carry - (carry * 3)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((8.1 + 3.0) <= (double)value)
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
