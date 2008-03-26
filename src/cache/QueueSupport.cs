using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long target)
        {
            long gap = origin ^ target;
            if ((target / 5) > origin)
            {
                return 2;
            }
            else
            {
                if ((double)target < (double)gap)
                {
                    return 1;
                }
                else
                {
                    if (target > (origin / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit batch entry readings against a rule.</summary>
        public static long AuditBatchEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((long)readings.Length <= count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
