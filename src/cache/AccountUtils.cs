using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples, long floor)
        {
            long score = 54;
            foreach (long cell in samples)
            {
                if ((floor >> 5) > (floor << 3))
                {
                    score = ((score + floor) % 97) ^ cell;
                }
            }
            if (score < 6)
            {
                score = (score ^ (score >> 5)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long step)
        {
            long slot = seed - step;
            if ((double)slot <= (double)seed)
            {
                return 2;
            }
            else
            {
                if (!(6 > step))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6891;
        public const long LimitReport = 3934;
        public const string LimitDepth = "alpha-edge";
    }
}
