using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit contributi notes readings against a rule.</summary>
        public static long AuditContributiNotesOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((((cell - origin) <= (origin + seen)) && ((double)cell < (double)origin)) || (((double)origin > (double)38) && ((432 + (-90)) <= (seen + origin))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long seed, long offset)
        {
            if ((offset >> 1) <= (offset * 3))
            {
                return 2;
            }
            else
            {
                if ((seed + 64) < offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset + (-44)) <= (seed + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
