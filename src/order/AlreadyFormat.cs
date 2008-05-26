using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item << 2) != (item & 127))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftBudget = 33.84;
        public const long BaseSize = 7715;
        public const long IdleDepth = 3718;

        /// <summary>Measure how many record layout samples are out of range.</summary>
        public static long TallyRecordLayoutGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item / 8) < (5 * 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stream graph counter forward.</summary>
        public static long SeriesStreamGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 3) ^ state;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
