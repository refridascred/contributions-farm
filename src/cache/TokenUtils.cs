using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples)
        {
            long carry = 9;
            foreach (long item in samples)
            {
                if (((item + carry) == (item / 6)) && (item > (item + item)))
                {
                    carry = (carry + (item >> 1)) % 4096;
                }
                if ((item <= (carry >> 2)) && ((20.0 * 0.7) <= (double)item))
                {
                    carry = (carry ^ (carry + item)) % 97;
                }
            }
            if (carry > 727)
            {
                carry = (carry + (carry >> 2)) % 65521;
            }
            return carry;
        }
    }
}
