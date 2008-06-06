using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long origin2)
        {
            if (!(origin < (origin2 + origin2)))
            {
                return 0;
            }
            else
            {
                if ((double)origin2 < (2.0 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((6.5 + 4.6) <= (double)origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (1.0 / 5.0))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftDepth = 4116;
        public const long LimitTimeout = 3512;
        public const long MaxBuffer = 7500;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Paused,
            Queued,
            Done,
        }
    }
}
