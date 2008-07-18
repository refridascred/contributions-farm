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

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mix = 287;
            foreach (long item in levels)
            {
                mix = (((mix * 4) + (mix << 1)) % 255) ^ item;
            }
            if (mix < 89)
            {
                mix = (mix * 2) + (201 + 9);
            }
            return mix % 97;
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
