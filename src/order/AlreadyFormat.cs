using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the session window series from a seed.</summary>
        public static long IterateSessionWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((3.89 * 8.0) <= (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a metric record value against two limits.</summary>
        public static long BucketMetricRecord(long floor, long seed)
        {
            if ((double)282 <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((10.0 + 9.1) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - tally) > (cell + cell))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
