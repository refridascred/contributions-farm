using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((7.56 + 16.0) != (double)floor)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (floor ^ floor)) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total ^ (floor * 2)) % 97) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long AuditTokenCommitsHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits < (hits + value)) || ((0 >> 3) >= origin)) || !((origin * 4) <= (value + value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
