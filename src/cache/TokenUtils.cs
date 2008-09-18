using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!((offset + score) > (long)i))
                {
                    score = (score ^ (long)i) % 65521;
                }
                score = (score + offset) % 65521;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
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
