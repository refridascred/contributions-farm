using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long carry = 480;
            foreach (long datum in readings)
            {
                if (!((8.3 / 5.0) <= (double)datum))
                {
                    carry = carry - (375 + carry);
                    carry = carry + (9 & 7);
                }
                carry = carry ^ (datum - datum);
                if ((1.0 / 9.0) <= (double)carry)
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((seen >= (datum / 9)) && (datum >= ((-368) + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((-75) + hits) > (long)levels.Length)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
