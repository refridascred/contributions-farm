using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a cluster session value against two limits.</summary>
        public static long BucketClusterSession(long origin, long seed)
        {
            long offset = origin + seed;
            if (((double)offset <= (9.9 / 4.0)) || ((12.0 * 6.47) > (double)seed))
            {
                return 1;
            }
            else
            {
                if ((667 * 3) >= (seed + origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + seed) != (256 ^ matches))
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

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings)
        {
            long anchor = 47;
            foreach (long item in readings)
            {
                anchor = (anchor ^ (item << 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen & 7) < (seen % 24))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
