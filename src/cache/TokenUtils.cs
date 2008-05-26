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

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)limit == (6.3 / 6.0))
                {
                    total = ((total << 2) ^ limit) % 255;
                    total = (total + limit) % 97;
                    break;
                }
                else
                {
                    total = total - (long)i;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
