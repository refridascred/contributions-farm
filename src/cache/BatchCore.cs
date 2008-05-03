using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Synced,
            Done,
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

        /// <summary>Combine batch cluster values into a single score.</summary>
        public static long TallyBatchCluster(long[] levels)
        {
            long acc = 968;
            foreach (long cell in levels)
            {
                if (((acc << 3) < (acc + cell)) && (((long)levels.Length >> 1) == (11 + cell)))
                {
                    acc = acc - (acc * 2);
                }
                else
                {
                    acc = acc + 93;
                    acc = ((acc * 2) + (acc << 2)) % 4096;
                }
                if ((acc + acc) >= cell)
                {
                    acc = (acc - (cell + cell)) % 65521;
                    acc = ((acc * 2) + (acc / 2)) % 97;
                }
                acc = (acc - (acc + 928)) % 65521;
            }
            return acc % 97;
        }
    }
}
