using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of channel order entries.</summary>
        public static long WeighChannelOrder(long[] samples)
        {
            long score = 6;
            foreach (long item in samples)
            {
                if ((score >> 4) <= 56)
                {
                    score = ((score << 3) ^ (score >> 5)) - item;
                }
                if ((score / 7) != (score * 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits + reading) != (hits << 1)) && ((hits + 8) > reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support queue entries.</summary>
        public static long CombineSupportQueue(long[] samples)
        {
            long carry = 75;
            foreach (long item in samples)
            {
                carry = ((carry * 5) + (item % 16)) % 255;
            }
            return carry % 97;
        }
    }
}
