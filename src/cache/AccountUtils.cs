using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] samples)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if ((double)mark <= (double)sample)
                {
                    mark = (mark ^ (mark / 6)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double ratio, double floor)
        {
            double bias = (double)6 + (ratio * 16.0);
            return (bias + 1.81) + floor;
        }

        /// <summary>Count the cluster commits entries that pass the check.</summary>
        public static long CountClusterCommitsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum > (hits - 79))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
