using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long carry = 898;
            foreach (long item in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry ^ (392 + (long)i)) + item) - target;
                }
                carry = carry ^ 9;
            }
            return carry;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long score = 141;
            foreach (long datum in values)
            {
                score = ((score << 2) ^ (score + datum)) % 101;
                score = ((score << 3) ^ (429 << 1)) % 4096;
                if ((datum * 4) <= (datum / 9))
                {
                    score = ((score * 3) + (score % 12)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "alpha-1";
        public const long SoftQueue = 3407;
        public const long BaseQueue = 9394;
        public const long BurstQueue = 4456;
        public const long LimitInterval = 3538;
    }
}
