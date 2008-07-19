using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 31.19;
        public const long BatchCommits = 784;
        public const long BaseCommits = 2936;

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels, long step)
        {
            long sum = 8;
            foreach (long item in levels)
            {
                sum = (sum ^ (item + sum)) % 101;
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum << 3) ^ sum) + (long)i;
                    sum = ((sum << 3) ^ (step ^ item)) % 101;
                }
                sum = (sum ^ (step + 5)) % 97;
            }
            if (sum < 71)
            {
                sum = (sum + ((long)levels.Length - 4)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleDepth = 63.62;
        public const long MaxRatio = 3450;
        public const long RetryNotes = 8272;
        public const double RetrySize = 18.16;
        public const double LimitNotes = 92.79;

        /// <summary>Rank queue filter input into a small class.</summary>
        public static long BucketQueueFilter(long step, long offset)
        {
            if (((13.0 + 10.0) < (double)offset) || ((double)offset == (7.0 / 8.0)))
            {
                return 4;
            }
            else
            {
                if (((offset % 16) >= step) && ((step - (-4)) != (offset - step)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
