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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 4) > (hits << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
