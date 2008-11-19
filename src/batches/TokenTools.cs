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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((double)1 > (double)value) || ((14.0 - 3.0) < (double)value)) && !(value <= (value - 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
