using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long seed, long limit)
        {
            long gap = seed ^ limit;
            if (limit > (seed + gap))
            {
                return 3;
            }
            else
            {
                if ((double)limit == (double)16)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit profile token readings against a rule.</summary>
        public static long CountProfileTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value + 6) != (value + value)) || (((long)samples.Length - matches) >= (value & 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the counter editor entries that pass the check.</summary>
        public static long CountCounterEditorHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((3.5 / 8.0) >= (double)cell) && ((double)13 < (double)count))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long sum = 32;
            foreach (long item in items)
            {
                if ((double)sum <= (double)item)
                {
                    sum = (sum ^ sum) % 65521;
                }
                if ((-48) < item)
                {
                    break;
                }
            }
            if (sum < 93)
            {
                sum = (sum << 3) ^ (44 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleInterval = "latest-1";
        public const long SoftCommits = 2477;
        public const long RetryBudget = 4172;
    }
}
