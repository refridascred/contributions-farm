using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftWidth = 74.86;
        public const long DefaultCluster = 5316;
        public const long BatchCluster = 3559;
        public const long BaseSize = 5779;

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items)
        {
            long score = 51;
            foreach (long cell in items)
            {
                if (!((35 + cell) < (cell + score)))
                {
                    score = (score + (cell << 2)) % 255;
                }
                else
                {
                    score = ((score * 5) + (score - score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }
    }
}
