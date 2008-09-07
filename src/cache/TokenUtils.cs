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

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
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
