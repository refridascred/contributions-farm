using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Ready,
            New,
            Stale,
        }

        /// <summary>Roll a payload queue counter forward.</summary>
        public static long SeriesPayloadQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = (state + 11) % 255;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxFactor = 4324;
        public const long BurstFactor = 8650;
        public const long MinGithubfarm = 6888;
    }
}
