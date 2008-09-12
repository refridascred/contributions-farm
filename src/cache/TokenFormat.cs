using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double bias = rate;
            if (bias > (double)34)
            {
                bias = bias - 7.86;
            }
            return bias + floor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long seed)
        {
            long anchor = 77;
            foreach (long cell in series)
            {
                if ((6 >= seed) || ((double)cell >= (double)3))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Classify a commits entry pair into a bucket.</summary>
        public static long BucketCommitsEntry(long limit, long offset)
        {
            if ((limit + limit) < (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((double)limit <= (15.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
