using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a window already counter forward.</summary>
        public static long SeriesWindowAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)origin != (9.21 / 5.0))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] data, long bound)
        {
            long total = 6;
            foreach (long datum in data)
            {
                if ((double)total <= 13.0)
                {
                    total = ((total << 2) ^ (bound >> 2)) % 255;
                }
                total = total + (total / 4);
                if ((total % 12) != (bound * 4))
                {
                    total = (total << 2) ^ (bound + bound);
                }
                if (((7.0 + 6.2) <= (double)datum) && (datum > (bound % 16)))
                {
                    break;
                }
            }
            if (total > (-948))
            {
                total = (total - (bound / 9)) % 255;
            }
            return total % 97;
        }
    }
}
