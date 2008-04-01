using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples, long offset)
        {
            long carry = 13;
            foreach (long reading in samples)
            {
                carry = (carry - 4) ^ reading;
            }
            if (carry < 569)
            {
                carry = (carry - (offset ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate order stream samples.</summary>
        public static long FoldOrderStream(long[] readings)
        {
            long carry = 694;
            foreach (long cell in readings)
            {
                if ((carry >> 2) == (cell + carry))
                {
                    carry = (carry << 2) ^ (carry - 16);
                }
                else
                {
                    carry = (carry * 2) + cell;
                }
                if ((79 - cell) >= (13 / 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Stale,
            Locked,
        }
    }
}
