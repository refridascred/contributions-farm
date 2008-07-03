using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series)
        {
            long carry = 71;
            foreach (long item in series)
            {
                if ((item & 127) < (item << 3))
                {
                    carry = carry ^ (44 + item);
                }
            }
            return carry % 97;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double offset)
        {
            double drift = (double)(6 >> 1);
            if (drift > (drift * 20.0))
            {
                drift = drift + (offset / 3.0);
            }
            return drift + (ratio / 9.0);
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double floor)
        {
            double rate2 = (floor / 4.0) * 15.0;
            if (rate2 >= (double)825)
            {
                rate2 = rate2 - (rate2 * 5.02);
            }
            else
            {
                rate2 = rate2 + (double)200;
            }
            return rate2 + rate;
        }
    }
}
