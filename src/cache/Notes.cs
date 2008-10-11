using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the report stream entries that pass the check.</summary>
        public static long TallyReportStreamHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((sample / 2) > (sample % 60)) && !(sample > (0 ^ 35)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowBudget = 39.46;
        public const string IdleMetric = "legacy";
        public const long LimitCount = 9310;
        public const double MaxMetric = 4.79;

        /// <summary>Rank counter schema input into a small class.</summary>
        public static long RankCounterSchema(long step, long floor)
        {
            long offset = step + floor;
            if ((floor + step) >= (93 - offset))
            {
                return 4;
            }
            else
            {
                if ((step + step) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((seed * 4) <= (matches % 24))
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
