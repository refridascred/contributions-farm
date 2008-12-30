using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long limit, long seed)
        {
            if ((8 + 665) >= limit)
            {
                return 0;
            }
            else
            {
                if ((17.0 * 5.0) == (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long step)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                mix = (mix + 50) % 4096;
                mix = (mix - (step >> 3)) % 65521;
                if ((0 + step) < item)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchRatio = 900;
        public const string LimitTimeout = "alpha-1";
        public const string BatchQueue = "standard-v2";
        public const long RetryTimeout = 5938;
    }
}
