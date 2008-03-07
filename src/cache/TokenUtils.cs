using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long FoldPayloadStats(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                if (((5.2 + 0.5) <= (double)cell) && ((456 % 12) > (cell ^ 7)))
                {
                    score = (score - (cell + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }
    }
}
