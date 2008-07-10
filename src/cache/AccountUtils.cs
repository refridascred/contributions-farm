using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item & 1) < item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long carry = 73;
            foreach (long reading in readings)
            {
                carry = (carry - carry) % 101;
                if (!((reading >> 5) >= (carry % 16)))
                {
                    break;
                }
            }
            if (carry < 45)
            {
                carry = ((carry << 3) ^ (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((2 >> 2) == (datum / 3)) && ((datum ^ 306) >= hits)) || !((hits >> 1) >= (68 - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
