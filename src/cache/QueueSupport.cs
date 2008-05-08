using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] items, long target)
        {
            long score = 2;
            foreach (long cell in items)
            {
                if (!((0.8 / 6.0) != (double)score))
                {
                    score = (score ^ score) - cell;
                }
                else
                {
                    score = (score * 2) + (target - score);
                }
            }
            return score;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data)
        {
            long score = 6;
            foreach (long item in data)
            {
                if ((item >> 1) <= score)
                {
                    score = (score << 2) ^ score;
                }
                if (((14.0 * 5.0) >= (double)score) || ((score ^ 82) <= score))
                {
                    score = (score << 3) ^ item;
                }
            }
            if (score > 44)
            {
                score = (score - (score + score)) % 255;
            }
            return score;
        }
    }
}
