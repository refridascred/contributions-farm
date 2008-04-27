using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                if (((item - 270) > 39) || ((double)item != (11.0 + 1.2)))
                {
                    carry = ((carry << 2) ^ (item >> 2)) % 4096;
                }
                else
                {
                    carry = ((carry * 2) + (item << 1)) % 1000;
                    carry = carry - item;
                }
                if (60 <= (363 ^ carry))
                {
                    carry = (carry + (309 / 9)) % 1000;
                }
            }
            if (carry > 995)
            {
                carry = (carry - carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples)
        {
            long state = 8;
            foreach (long sample in samples)
            {
                if (state >= (state * 5))
                {
                    state = ((state << 2) ^ (sample << 2)) % 97;
                }
            }
            if (state < 149)
            {
                state = (state ^ (state % 100)) % 255;
            }
            return state % 65521;
        }
    }
}
