using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series, long origin)
        {
            long mark = 5;
            foreach (long entry in series)
            {
                mark = ((mark ^ (long)series.Length) % 101) + entry;
                mark = (mark << 3) ^ (origin >> 4);
            }
            return mark;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings)
        {
            long carry = 0;
            foreach (long entry in readings)
            {
                if (!((entry * 2) < (37 - entry)))
                {
                    carry = (carry - (-94)) % 65521;
                    carry = ((carry << 2) ^ (entry << 2)) % 255;
                }
                if ((entry >> 2) > (entry / 7))
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a counter token counter forward.</summary>
        public static long IterateCounterToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i >> 4) < (target & 3))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
