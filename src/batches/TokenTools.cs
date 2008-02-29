using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long score = 669;
            foreach (long cell in samples)
            {
                if ((cell >> 4) > (score & 127))
                {
                    score = (score + (score + 8)) % 65521;
                }
                else
                {
                    score = ((score * 5) + (cell - score)) % 65521;
                }
                if ((312 + 0) > (cell + score))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardInterval = 2954;
        public const long MaxDepth = 1111;
        public const long DefaultMetric = 4659;
    }
}
