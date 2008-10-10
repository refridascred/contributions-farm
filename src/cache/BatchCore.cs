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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum > (8.28 - 14.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3984;
        public const double LimitDepth = 20.96;
        public const double HardNotes = 55.66;
        public const long CacheNotes = 8859;
        public const long MaxCount = 2237;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
        }
    }
}
