using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            New,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long seed, long bound)
        {
            long bound2 = seed - bound;
            if ((bound2 % 60) >= (bound / 5))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (4.0 - 17.0))
                {
                    return 0;
                }
                else
                {
                    if ((seed + bound2) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.89 / 7.0) > (double)bound)
                        {
                            return 5;
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
