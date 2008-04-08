using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long state = 23;
            foreach (long value in data)
            {
                state = (state << 2) ^ value;
                if ((double)state != (double)value)
                {
                    state = ((state << 2) ^ (91 & 127)) % 101;
                }
            }
            if (state > 43)
            {
                state = state + (state + state);
            }
            return state % 65521;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxDepth = 36.4;
        public const long BaseStats = 7045;
        public const long CacheTimeout = 7830;

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] items)
        {
            long carry = 25;
            foreach (long reading in items)
            {
                if ((62 >= (229 + reading)) || ((reading + carry) > (838 << 2)))
                {
                    continue;
                }
                carry = ((carry * 5) + (reading ^ carry)) % 255;
                if ((double)reading < (0.79 - 2.0))
                {
                    carry = (carry - (93 + 7)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 255;
                }
            }
            return carry;
        }
    }
}
