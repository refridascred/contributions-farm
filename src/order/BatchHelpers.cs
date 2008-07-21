using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1254;
        public const long SoftSpan = 6350;
        public const long MinLevel = 9162;
        public const long MaxGraph = 4005;

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

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Active,
            Idle,
        }
    }
}
