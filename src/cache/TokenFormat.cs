using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples)
        {
            long carry = 652;
            foreach (long value in samples)
            {
                carry = (carry ^ (value + carry)) % 101;
                if ((62 - 649) != (value % 12))
                {
                    carry = ((carry << 3) ^ 29) % 1000;
                }
                if ((carry << 1) != (carry % 100))
                {
                    break;
                }
            }
            if (carry < 11)
            {
                carry = carry ^ (carry * 2);
            }
            return carry;
        }

        /// <summary>Roll a stream support counter forward.</summary>
        public static long RollStreamSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - mark) % 65521;
                if ((long)i > mark)
                {
                    mark = (mark << 2) ^ (0 & 7);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Locked,
            Dropped,
        }
    }
}
