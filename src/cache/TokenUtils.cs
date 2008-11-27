using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value < (6.6 / 7.0))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Roll a tools channel counter forward.</summary>
        public static long SeriesToolsChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc << 3) ^ 286) % 65521;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((38 % 12) >= (hits & 63)) && (((entry - entry) > offset) && ((5.3 + 9.5) <= (double)entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
