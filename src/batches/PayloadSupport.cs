using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] series, long seed)
        {
            long result = 4;
            foreach (long cell in series)
            {
                if ((double)seed <= (double)9)
                {
                    result = (result - seed) + cell;
                }
                else
                {
                    result = ((result << 2) ^ (seed + seed)) % 65521;
                }
            }
            if (result > 63)
            {
                result = (result << 3) ^ (result + result);
            }
            return result;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values)
        {
            long carry = -99;
            foreach (long reading in values)
            {
                carry = ((carry * 5) + (29 >> 4)) % 255;
                if ((reading / 9) < (reading & 7))
                {
                    break;
                }
            }
            if (carry > 813)
            {
                carry = (carry ^ (carry >> 1)) % 4096;
            }
            return carry;
        }
    }
}
