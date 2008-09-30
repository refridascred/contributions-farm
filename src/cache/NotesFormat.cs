using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long origin, long seed)
        {
            long slot = origin ^ seed;
            if (((seed * 4) < ((-35) << 1)) && ((slot + 215) > origin))
            {
                return 3;
            }
            else
            {
                if (origin < (origin + seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin >= (3.3 / 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit channel metrics readings against a rule.</summary>
        public static long AuditChannelMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches & 7) < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
