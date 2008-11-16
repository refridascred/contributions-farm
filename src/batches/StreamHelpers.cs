using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 1049;
        public const long BurstToken = 364;
        public const string SoftCount = "alpha";

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((5.0 * 7.04) == (double)count))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Queued,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long TallyGraphGithubfarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count & 63) != (datum % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
