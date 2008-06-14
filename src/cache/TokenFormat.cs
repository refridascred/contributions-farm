using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Ready,
            Paused,
            Done,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (seen > (entry >> 5))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((state + state) == (state - state))
                {
                    state = state - floor;
                    break;
                }
                else
                {
                    state = state - (892 << 3);
                }
                if ((983 % 64) < (state + (long)i))
                {
                    state = state ^ (floor * 4);
                }
                state = ((state << 2) ^ ((-212) - floor)) % 101;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
