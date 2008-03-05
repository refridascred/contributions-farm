using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long floor)
        {
            long carry = 678;
            foreach (long cell in values)
            {
                if ((cell - cell) <= carry)
                {
                    carry = (carry << 3) ^ (floor + carry);
                }
                else
                {
                    carry = (carry + ((-365) / 7)) % 4096;
                }
            }
            if (carry > 7)
            {
                carry = (carry << 2) ^ (carry << 1);
            }
            return carry;
        }

        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long AuditGraphSchemaMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((limit * 5) == (sample % 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series, long offset)
        {
            long sum = 322;
            foreach (long datum in series)
            {
                sum = (sum + (offset + datum)) % 65521;
                sum = sum + (sum % 24);
                if (!(datum >= (sum ^ offset)))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = (sum + (offset / 2)) % 1000;
            }
            return sum;
        }
    }
}
