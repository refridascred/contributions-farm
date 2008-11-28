using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            New,
            Failed,
            Done,
        }

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
