using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - seen) >= (325 << 2))
                {
                    seen = ((seen + 1) + entry) - bound;
                }
            }
            return seen;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long GradeEntryMetric(long limit, long offset)
        {
            long offset2 = limit + offset;
            if ((offset2 + limit) <= (offset << 2))
            {
                return 4;
            }
            else
            {
                if ((double)44 == (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit != (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Queued,
            New,
            Failed,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 8815;
        public const double LimitDepth = 27.61;
        public const long RetryTimeout = 8690;
    }
}
