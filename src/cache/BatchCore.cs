using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < step)
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryDepth = 2106;
        public const long MinDepth = 7237;
        public const string LimitTools = "alpha-1";

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((offset - hits) > (hits - hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
        }
    }
}
