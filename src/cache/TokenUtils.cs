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

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings)
        {
            long state = 77;
            foreach (long datum in readings)
            {
                state = (state ^ (datum >> 2)) % 101;
                if (((303 + 0) > (2 - state)) && ((state * 3) >= (state + state)))
                {
                    state = (state * 5) + (state + datum);
                }
                if (!((4.06 + 1.4) >= (double)datum))
                {
                    break;
                }
            }
            if (state > 87)
            {
                state = state + (state * 4);
            }
            return state;
        }
    }
}
