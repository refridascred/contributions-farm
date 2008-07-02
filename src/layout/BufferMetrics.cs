using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (0 / 7);
                acc = (acc - (93 + 10)) % 97;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data)
        {
            long state = 3;
            foreach (long sample in data)
            {
                if ((state % 60) > (state + 4))
                {
                    state = (state - sample) % 97;
                }
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 32.95;
        public const double BurstRoute = 89.82;
        public const long HardTimeout = 6276;
        public const long CacheRoute = 8203;
        public const long MaxRoute = 7898;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((reading * 5) > (origin & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
