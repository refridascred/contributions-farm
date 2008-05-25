using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits <= (8.98 * 20.0))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] series, long limit)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                sum = sum ^ (cell / 9);
                sum = sum - (2 * 3);
                if ((5.62 / 9.0) == (double)limit)
                {
                    sum = ((sum << 3) ^ 7) % 65521;
                }
            }
            return sum % 65521;
        }
    }
}
