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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 61.29;
        public const long SoftWidth = 7496;
        public const double MaxScore = 72.47;
        public const long StepWidth = 5031;
        public const long RetryWidth = 2953;

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
