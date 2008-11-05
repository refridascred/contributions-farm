using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if ((floor + 17) < (-93))
            {
                return 3;
            }
            else
            {
                if (bound < floor2)
                {
                    return 1;
                }
                else
                {
                    if (floor < (floor2 / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit cache session readings against a rule.</summary>
        public static long MeasureCacheSessionMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((double)floor < (double)seen) || ((double)seen >= (double)entry)) || (((long)series.Length & 1) >= ((long)series.Length + entry)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitFactor = 7792;
        public const string IdleTimeout = "strict";
        public const double MaxContext = 47.37;
        public const long SoftContext = 1973;
        public const long CacheInterval = 2862;
    }
}
