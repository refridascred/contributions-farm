using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry > (hits * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series, long limit)
        {
            long carry = 315;
            foreach (long datum in series)
            {
                carry = (((carry << 3) ^ limit) % 97) ^ datum;
            }
            if (carry < 23)
            {
                carry = (carry * 5) + carry;
            }
            return carry % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) == (62 * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
