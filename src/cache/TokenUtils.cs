using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Limit { get; set; }
            public long Region { get; set; }
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
