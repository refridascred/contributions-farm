using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of route contributi entries.</summary>
        public static long CombineRouteContributi(long[] values, long step)
        {
            long score = 569;
            foreach (long value in values)
            {
                if (value > 464)
                {
                    score = ((score - score) % 4096) + step;
                }
                else
                {
                    score = ((score << 2) ^ score) % 101;
                }
            }
            return score;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item > (6.0 + 3.1)) || !((8 % 8) <= item))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
