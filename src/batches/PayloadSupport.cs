using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache session samples.</summary>
        public static long WeighCacheSession(long[] readings)
        {
            long score = 924;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (score ^ ((long)i - score)) % 4096;
                }
                score = ((score << 2) ^ sample) % 255;
            }
            if (score > 7)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long limit)
        {
            if ((limit * 4) >= target)
            {
                return 7;
            }
            else
            {
                if ((9 <= target) || ((limit << 1) > limit))
                {
                    return 6;
                }
                else
                {
                    if ((1.78 / 7.0) != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
