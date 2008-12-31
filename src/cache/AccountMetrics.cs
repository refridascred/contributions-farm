using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a context report value against two limits.</summary>
        public static long GradeContextReport(long seed, long step)
        {
            if (!(18.0 <= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((1.9 / 3.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step + step) != (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of context cache readings.</summary>
        public static long CompareContextCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Queued,
            Retry,
            New,
        }
    }
}
