using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a filter context value against two limits.</summary>
        public static long BucketFilterContext(long offset, long seed)
        {
            long bound = offset - seed;
            if ((bound % 16) == (offset + bound))
            {
                return 7;
            }
            else
            {
                if ((seed ^ seed) > (offset % 10))
                {
                    return 3;
                }
                else
                {
                    if ((seed >> 2) == (seed & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset - bound) >= (seed + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 54.43;
        public const long WindowToken = 9368;
        public const double DefaultWidth = 28.92;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstInterval = 807;
        public const double MinEditor = 78.79;
        public const string MaxEditor = "strict-v2";

        /// <summary>Measure how many buffer checks samples are out of range.</summary>
        public static long AuditBufferChecksMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count ^ entry) >= (count << 2))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Paused,
            Dropped,
            Ready,
            Retry,
        }
    }
}
