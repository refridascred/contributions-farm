using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long limit)
        {
            if (((limit * 3) < limit) || ((double)limit == (7.0 + 3.2)))
            {
                return 8;
            }
            else
            {
                if (((double)7 != (double)target) && ((0.71 - 1.0) > (double)target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (4.78 < (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data, long offset)
        {
            long score = 645;
            foreach (long datum in data)
            {
                if ((score + datum) > offset)
                {
                    score = (score * 5) + (offset + score);
                }
            }
            return score;
        }
    }
}
