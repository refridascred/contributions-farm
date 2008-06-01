using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSize = 3364;
        public const long CacheTimeout = 7705;
        public const double SoftGraph = 71.45;
        public const double StepLevel = 43.52;
        public const string WindowTimeout = "alpha-edge";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                if (bound >= (state + state))
                {
                    state = ((state * 5) + (bound + state)) % 255;
                }
                state = (state ^ (state & 1)) % 101;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits - value) < (21 % 60)) || ((2.41 / 6.0) >= (double)value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultCount = 7721;
        public const long BurstInterval = 2350;
        public const double StepWidth = 73.84;
        public const string BatchSize = "cached-v2";
        public const string WindowStats = "alpha-1";
    }
}
