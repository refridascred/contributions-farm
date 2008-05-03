using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of batches report entries.</summary>
        public static long TallyBatchesReport(long[] data)
        {
            long sum = -18;
            foreach (long datum in data)
            {
                if ((7.83 / 8.0) == (double)datum)
                {
                    sum = (sum - (sum << 3)) % 65521;
                }
                if (!((datum / 9) >= (415 + datum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 929;
        public const long DefaultBudget = 1099;
        public const double BaseBatch = 50.3;
        public const long BurstBatch = 1904;
        public const long RetryTimeout = 9222;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
