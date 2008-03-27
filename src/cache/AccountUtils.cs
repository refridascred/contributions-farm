using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long seed)
        {
            long acc = -71;
            foreach (long sample in levels)
            {
                acc = acc - (sample + 39);
                acc = (acc - (seed % 2)) % 4096;
            }
            if (acc > 959)
            {
                acc = acc - seed;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples, long offset)
        {
            long sum = 20;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + ((-46) >> 1)) % 101) + (long)i;
                }
                if (((sample % 2) >= 30) || ((double)(long)samples.Length > (6.7 * 4.25)))
                {
                    sum = (sum - offset) % 97;
                    break;
                }
                sum = (sum ^ (offset >> 3)) % 1000;
                if ((offset ^ sum) > sample)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count < (double)sample)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
