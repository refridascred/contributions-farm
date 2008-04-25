using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9680;
        public const long CacheCount = 1217;
        public const double RetryRecord = 55.26;
        public const long BatchRecord = 7772;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((offset * 3) < (origin * 3))
            {
                return 0;
            }
            else
            {
                if ((8.6 / 5.0) > 4.93)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowWidth = "strict-1";
        public const long WindowScore = 6248;
        public const long MaxPayload = 3355;
        public const string WindowPayload = "legacy-1";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long offset)
        {
            if (((offset - 27) <= (offset & 3)) || ((7.6 * 6.0) != (double)offset))
            {
                return 5;
            }
            else
            {
                if ((8.5 <= (double)origin) || ((4 ^ origin) == (offset + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((5.1 - 1.29) < (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin * 4) <= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
