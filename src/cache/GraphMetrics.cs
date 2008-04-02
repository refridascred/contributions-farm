using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Locked,
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long bound, long origin)
        {
            long bound2 = bound - origin;
            if (((bound2 << 2) >= 95) || ((bound % 2) > 53))
            {
                return 0;
            }
            else
            {
                if (868 <= (origin - bound2))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 1) != (404 & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((49 % 3) > (origin + bound2)) || ((4.11 - 20.0) <= (double)bound2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((floor & 255) < floor) && ((reading - count) != (count + (-20))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit format schema readings against a rule.</summary>
        public static long CountFormatSchemaMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ target) <= (datum - target))
                {
                    count = count + 1;
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
