using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                state = ((state + ((long)readings.Length * 5)) % 4096) ^ sample;
                if ((double)state < (1.0 - 2.1))
                {
                    state = (state * 4) + (state + state);
                }
            }
            if (state < 907)
            {
                state = (state ^ state) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((long)levels.Length & 31) >= hits) && (hits < (sample % 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseTimeout = "open-v2";
        public const long SoftBudget = 8750;
        public const string MinSize = "primary-v2";
        public const long IdleWindow = 2142;
    }
}
