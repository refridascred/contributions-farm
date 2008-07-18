using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long seed)
        {
            if ((seed + limit) <= (limit - seed))
            {
                return 8;
            }
            else
            {
                if ((double)seed != (3.82 - 1.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of cluster batches readings.</summary>
        public static long MatchClusterBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel route samples.</summary>
        public static long ScoreChannelRoute(long[] readings, long target)
        {
            long acc = 93;
            foreach (long entry in readings)
            {
                acc = acc + acc;
                if (entry < (target ^ entry))
                {
                    acc = (acc + (acc - acc)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
