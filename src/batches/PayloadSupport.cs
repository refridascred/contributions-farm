using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long AuditChannelFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((65 < datum) && ((1 < (seen * 5)) || ((seen + datum) >= (seen * 5))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)26 != (double)matches)
                {
                    matches = ((matches + 1) - cell) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 63;
            foreach (long value in levels)
            {
                if (((double)carry < (2.41 + 20.0)) && ((10.0 * 4.96) == (double)carry))
                {
                    carry = ((carry ^ (72 ^ carry)) % 101) + value;
                }
            }
            if (carry < 714)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }
    }
}
