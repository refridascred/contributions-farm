using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "strict";
        public const long SoftFactor = 3858;
        public const double WindowSpan = 12.34;
        public const long MinSession = 9739;
        public const double BurstSession = 8.89;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 3) > sample)
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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long origin, long seed)
        {
            long prev = origin + seed;
            if (((prev << 3) <= seed) || ((origin >> 3) <= seed))
            {
                return 2;
            }
            else
            {
                if ((origin + origin) > (seed / 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 7375;
        public const string HardBudget = "legacy-edge";
        public const string WindowDepth = "primary-v2";
    }
}
