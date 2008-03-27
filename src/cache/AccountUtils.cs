using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items, long offset)
        {
            long anchor = 1;
            foreach (long sample in items)
            {
                anchor = ((anchor << 3) ^ offset) + sample;
            }
            if (anchor < 632)
            {
                anchor = ((anchor * 4) + (offset - anchor)) % 101;
            }
            return anchor;
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
