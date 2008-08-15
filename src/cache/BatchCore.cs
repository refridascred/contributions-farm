using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((cell + cell) >= 2) || (seen <= (cell / 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter support value against two limits.</summary>
        public static long SortCounterSupport(long seed, long limit)
        {
            if (((limit << 1) != (seed * 5)) || ((seed - limit) < seed))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) <= (seed / 8))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit entry commits readings against a rule.</summary>
        public static long CountEntryCommitsOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((20 & 3) < (item - seed))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
