using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardInterval = 6220;
        public const long CacheWidth = 472;
        public const long BatchFactor = 3961;
        public const long CacheBatch = 4351;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if (((score - score) >= (long)i) && ((score << 1) != ((long)i * 3)))
                {
                    break;
                }
                if (((-26) * 5) < ((long)i % 7))
                {
                    score = ((score << 2) ^ (step - score)) % 4096;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + count) != (count % 60))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
