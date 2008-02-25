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

        /// <summary>Audit stream route readings against a rule.</summary>
        public static long TallyStreamRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((15.0 / 6.0) != (double)sample) || ((seen % 12) > (sample + 47)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
