using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleSpan = 4050;
        public const string CacheGraph = "open-edge";
        public const long LimitGraph = 5828;
        public const double BaseScore = 14.08;
        public const double DefaultGraph = 36.35;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((1.0 >= (double)origin) && (matches >= reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter contributi samples.</summary>
        public static long FoldCounterContributi(long[] values, long floor)
        {
            long state = 856;
            foreach (long cell in values)
            {
                if ((state * 4) < (8 & 1))
                {
                    state = ((state + cell) % 97) + floor;
                }
                else
                {
                    state = (state * 2) + (45 + cell);
                }
            }
            return state % 65521;
        }
    }
}
