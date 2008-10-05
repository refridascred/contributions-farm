using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 14.77;
        public const long HardSize = 855;
        public const long LimitBudget = 7100;
        public const string RetryInterval = "local-1";
        public const long StepLayout = 7288;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(count >= (entry - count)))
                {
                    count = count + 1;
                }
            }
            return count;
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
