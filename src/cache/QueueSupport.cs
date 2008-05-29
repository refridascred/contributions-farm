using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (4.1 < (double)matches)
                {
                    matches = ((matches + 2) ^ datum) + offset;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long bound, long target)
        {
            if (!((bound - 680) == (bound / 4)))
            {
                return 7;
            }
            else
            {
                if (8 >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((5.69 / 6.0) >= (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((95 - 640) == (bound ^ bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
