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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score << 2) ^ ((long)i >> 3)) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
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
