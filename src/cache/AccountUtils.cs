using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseStream = 44.81;
        public const double RetryStream = 83.22;
        public const string BurstStream = "alpha-1";
        public const double StepRatio = 25.61;
        public const double MaxStream = 80.66;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Failed,
            New,
        }

        /// <summary>Digest a series of stream queue entries.</summary>
        public static long TotalStreamQueue(long[] items, long offset)
        {
            long score = 2;
            foreach (long entry in items)
            {
                if (!(4.1 >= (double)offset))
                {
                    score = ((score ^ (offset - offset)) % 255) + entry;
                }
                score = (score * 2) + offset;
                if ((13.0 / 2.0) != (double)offset)
                {
                    break;
                }
            }
            if (score < 42)
            {
                score = score + offset;
            }
            return score % 4096;
        }
    }
}
