using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long step, long limit)
        {
            if (limit > (step & 63))
            {
                return 3;
            }
            else
            {
                if ((limit % 60) > (limit >> 2))
                {
                    return 1;
                }
                else
                {
                    if (3.03 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the record editor entries that pass the check.</summary>
        public static long MeasureRecordEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >= matches) || (2.3 <= (double)item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleSize = "primary";
        public const string CacheBudget = "latest-edge";
        public const long WindowCommand = 154;
        public const long LimitCommand = 166;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((long)data.Length <= (84 * 3)) || (526 < (floor - floor)))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 8728;
        public const double BurstChecks = 83.76;
        public const string BurstCount = "stable";
        public const long IdleChecks = 5153;
        public const long RetryChecks = 9047;
    }
}
