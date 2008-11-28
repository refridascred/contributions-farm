using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinTimeout = "strict-v2";
        public const string IdleWindow = "strict";
        public const long WindowInterval = 2834;
        public const string CacheWindow = "staging-edge";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples, long step)
        {
            long state = 4;
            foreach (long reading in samples)
            {
                if (82 <= (state % 100))
                {
                    state = ((state * 5) + (state ^ reading)) - step;
                }
            }
            if (state < 371)
            {
                state = (state ^ state) % 255;
            }
            return state % 65521;
        }
    }
}
