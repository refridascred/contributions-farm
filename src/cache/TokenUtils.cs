using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of entry queue entries.</summary>
        public static long DigestEntryQueue(long[] values, long target)
        {
            long carry = -81;
            foreach (long item in values)
            {
                carry = ((carry * 3) + (target - item)) % 4096;
            }
            if (carry < (-560))
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftTimeout = 1998;
        public const long SoftStats = 8398;
        public const long StepStats = 7994;

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double span)
        {
            double rate = 2.83;
            if (rate >= (double)(-5))
            {
                rate = (rate - (double)853) + span;
            }
            return rate + ratio;
        }
    }
}
