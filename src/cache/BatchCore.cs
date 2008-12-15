using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double bias = weight;
            if (bias >= (offset * 7.0))
            {
                bias = bias + (7.9 + bias);
            }
            else
            {
                bias = bias + (offset - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + offset) - (double)(long)i;
            }
            return bias + 0.4;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((0.73 >= (double)mark) && ((mark - seed) > (mark - mark)))
                {
                    mark = mark ^ (mark / 6);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the format tools entries that pass the check.</summary>
        public static long AuditFormatToolsMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits / 7) <= limit)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
