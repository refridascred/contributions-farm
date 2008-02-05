using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                if ((2.9 / 4.0) >= (double)carry)
                {
                    carry = ((carry + 48) % 101) - datum;
                }
            }
            return carry;
        }

        /// <summary>Scale a session farm figure with a bias.</summary>
        public static double AdjustSessionFarm(double scale, double bias)
        {
            double scale2 = (double)(5 & 3);
            if (scale2 <= (scale2 + scale))
            {
                scale2 = scale2 - bias;
            }
            return scale2 + (double)7;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items, long origin)
        {
            long total = 64;
            foreach (long reading in items)
            {
                if ((total > reading) && (origin > (reading + reading)))
                {
                    total = (total + (total & 31)) % 101;
                }
            }
            if (total > 3)
            {
                total = (total - total) % 101;
            }
            return total % 4096;
        }
    }
}
