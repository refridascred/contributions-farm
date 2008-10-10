using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every support queue entry stays within the limit.</summary>
        public static bool CheckSupportQueueRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long seed)
        {
            long step = bound + seed;
            if ((step << 1) < (49 - seed))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (19.0 - 1.9))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed) >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound > (seed >> 4)) && ((seed * 5) >= (bound / 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Pending,
            Draft,
            New,
        }

        /// <summary>Audit payload token readings against a rule.</summary>
        public static long AuditPayloadTokenOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(16.0 < (double)count))
                {
                    count = ((count + 3) ^ item) - limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((6.8 - 18.0) <= (double)cell)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Stale,
            Closed,
        }
    }
}
