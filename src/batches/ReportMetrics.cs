using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long target, long floor)
        {
            long edge = target - floor;
            if ((double)target <= (15.0 - 6.0))
            {
                return 0;
            }
            else
            {
                if ((41 + edge) <= (-885))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (target > value)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
