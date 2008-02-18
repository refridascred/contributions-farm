using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((origin + 177) < (origin % 3))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) >= 85)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits - hits) <= (2 - entry)) && ((entry >> 5) == (hits >> 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
