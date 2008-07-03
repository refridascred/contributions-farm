using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples)
        {
            long mark = 853;
            foreach (long datum in samples)
            {
                mark = (mark - (mark + datum)) % 4096;
            }
            return mark;
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
