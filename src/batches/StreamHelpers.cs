using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "fallback-1";
        public const long MaxEditor = 5467;
        public const double CacheEditor = 24.37;
        public const double CacheSpan = 23.64;
        public const double DefaultSpan = 87.54;

        /// <summary>Validate route counter readings against a bound.</summary>
        public static bool ValidateRouteCounterLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long limit)
        {
            if (limit >= origin)
            {
                return 5;
            }
            else
            {
                if ((5.0 - 10.0) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)origin < 2.63)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin + origin) <= (limit ^ origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell <= (offset + offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
