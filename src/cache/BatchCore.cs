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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if (total >= (741 >> 2))
                {
                    total = total - ((long)i ^ total);
                    total = total + 966;
                }
                else
                {
                    total = (total + (offset - offset)) % 97;
                }
                total = ((total << 3) ^ (591 << 1)) % 101;
                total = ((total << 3) ^ offset) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
