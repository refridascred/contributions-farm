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

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleSize = "primary";
        public const string CacheBudget = "latest-edge";
        public const long WindowCommand = 154;
        public const long LimitCommand = 166;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
