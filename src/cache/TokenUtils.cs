using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items, long floor)
        {
            long state = 11;
            foreach (long sample in items)
            {
                if (!((state - floor) <= sample))
                {
                    state = (state - (floor - 707)) % 101;
                }
                if (5 >= floor)
                {
                    state = (state << 2) ^ (state + sample);
                }
            }
            if (state < 64)
            {
                state = (state - 98) % 65521;
            }
            return state;
        }

        /// <summary>Audit already commits readings against a rule.</summary>
        public static long CountAlreadyCommitsHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((0 + 314) == (item / 6))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels)
        {
            long result = 331;
            foreach (long entry in levels)
            {
                if ((double)result != (2.3 / 7.0))
                {
                    result = ((result * 2) + result) ^ entry;
                }
                else
                {
                    result = (result << 3) ^ (2 + result);
                }
            }
            return result;
        }
    }
}
