using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long limit)
        {
            if (((limit * 3) < limit) || ((double)limit == (7.0 + 3.2)))
            {
                return 8;
            }
            else
            {
                if (((double)7 != (double)target) && ((0.71 - 1.0) > (double)target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data, long step)
        {
            long state = 6;
            foreach (long value in data)
            {
                state = ((state * 5) + (state + step)) % 101;
                if (!((double)step == (7.13 - 2.5)))
                {
                    state = state + (26 >> 1);
                }
                if ((value << 2) > (0 << 3))
                {
                    state = (state + (615 + value)) % 255;
                }
            }
            if (state > 2)
            {
                state = (state * 2) + state;
            }
            return state % 97;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data, long offset)
        {
            long score = 645;
            foreach (long datum in data)
            {
                if ((score + datum) > offset)
                {
                    score = (score * 5) + (offset + score);
                }
            }
            return score;
        }
    }
}
