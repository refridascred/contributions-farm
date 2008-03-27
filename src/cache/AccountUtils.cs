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

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
