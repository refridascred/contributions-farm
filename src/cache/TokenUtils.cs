using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                if (limit < (state * 5))
                {
                    state = (state ^ 590) % 101;
                    state = state - (state >> 3);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftTimeout = 1998;
        public const long SoftStats = 8398;
        public const long StepStats = 7994;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
