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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 2) + total;
                if ((bound * 3) < (bound % 16))
                {
                    total = ((total << 2) ^ (-51)) % 1000;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
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
