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

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values, long floor)
        {
            long sum = 1;
            foreach (long item in values)
            {
                if ((double)sum < 16.0)
                {
                    sum = (((sum + (sum >> 5)) % 1000) ^ item) - floor;
                }
                else
                {
                    sum = (sum << 2) ^ (-704);
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 3) + (678 << 2)) % 97;
            }
            return sum;
        }

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
