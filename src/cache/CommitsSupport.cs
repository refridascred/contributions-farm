using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state - state) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long target)
        {
            long cur = offset - target;
            if ((cur << 3) > (offset + cur))
            {
                return 6;
            }
            else
            {
                if ((cur + offset) < cur)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if (seed < ((long)i * 5))
                {
                    state = (state << 2) ^ (state << 3);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) > (-85))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxBudget = 3687;
        public const string BatchEditor = "open";
        public const long IdleFactor = 2382;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
