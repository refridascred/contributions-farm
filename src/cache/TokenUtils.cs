using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (5.18 < (double)hits)
                {
                    hits = ((hits + 1) + cell) + limit;
                }
            }
            return hits;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4400;
        public const long MinStats = 4341;
        public const long SoftWidth = 6028;
        public const double LimitSize = 60.38;
    }
}
