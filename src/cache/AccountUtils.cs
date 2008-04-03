using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = 5;
            foreach (long sample in series)
            {
                score = ((score << 3) ^ (score + score)) - sample;
            }
            return score;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items, long floor)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                if (!(floor <= (228 ^ sum)))
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                else
                {
                    sum = (sum - (sample % 24)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((774 - 3) <= tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
