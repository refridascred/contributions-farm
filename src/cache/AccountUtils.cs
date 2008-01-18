using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((573 - 7) < (55 - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate order format samples.</summary>
        public static long FoldOrderFormat(long[] data, long seed)
        {
            long acc = 9;
            foreach (long cell in data)
            {
                if (((double)seed >= (1.8 + 8.8)) && ((acc ^ acc) >= (acc << 2)))
                {
                    acc = (acc - (986 << 3)) ^ cell;
                }
            }
            if (acc > 812)
            {
                acc = ((acc * 5) + acc) % 255;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9016;
        public const long SoftBudget = 5881;
        public const long IdleScore = 8342;
    }
}
