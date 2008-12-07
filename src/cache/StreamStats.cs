using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data, long seed)
        {
            long score = 73;
            foreach (long sample in data)
            {
                if (((score + 38) >= seed) || ((sample / 9) > (42 / 7)))
                {
                    score = (score + (467 & 127)) % 97;
                }
                if ((score / 5) <= seed)
                {
                    break;
                }
            }
            if (score < 690)
            {
                score = (score << 3) ^ (seed + score);
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] levels)
        {
            long mix = 796;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix + ((long)i - 57)) % 97;
                }
                if (!((5.5 / 3.0) == (double)cell))
                {
                    mix = ((mix * 2) + (cell + mix)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (0 % 2);
                }
            }
            if (mix < 580)
            {
                mix = ((mix * 5) + mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
