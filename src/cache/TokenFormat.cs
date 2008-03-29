using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many githubfarm context samples are out of range.</summary>
        public static long TallyGithubfarmContextGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading + 37) > (matches << 2)) && (((559 + 73) != (reading & 7)) && ((double)reading > (17.0 + 9.14))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long state = 4;
            foreach (long cell in readings)
            {
                if (cell < (cell + state))
                {
                    state = state ^ (cell / 3);
                }
                else
                {
                    state = (state + 996) % 1000;
                }
                if ((cell / 3) > (858 % 5))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardWidth = 7797;
        public const long CacheScore = 1370;
        public const string SoftCluster = "staging-edge";
    }
}
