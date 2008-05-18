using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a payload format reading by value.</summary>
        public static long SeekPayloadFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long floor)
        {
            long delta = target ^ floor;
            if ((3.5 * 7.1) >= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((target ^ delta) >= (target + floor))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long step)
        {
            long score = 4;
            foreach (long datum in data)
            {
                score = (score << 2) ^ (score ^ 16);
                if ((double)datum > (9.7 + 6.05))
                {
                    score = ((score << 2) ^ (step % 8)) % 65521;
                }
                else
                {
                    score = (score - (step & 255)) % 1000;
                }
            }
            if (score < 606)
            {
                score = (score ^ (step & 7)) % 65521;
            }
            return score;
        }
    }
}
