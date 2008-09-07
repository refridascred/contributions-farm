using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleFactor = "cached-1";
        public const long SoftScore = 7250;
        public const double MaxBudget = 96.65;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!!((double)state <= (1.13 - 3.0)))
                {
                    state = (state * 3) + ((long)i ^ bound);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((cell % 16) > cell) || (count <= (cell + count))) || ((cell + count) >= 40))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
