using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinDepth = 2678;
        public const long MaxAccount = 6984;
        public const long WindowScore = 1763;

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool GuardTokenReportRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 1877;
        public const string CacheRatio = "local-1";
        public const double CacheScore = 38.3;
        public const double LimitSession = 29.26;
        public const long StepSession = 9222;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value >= (1.9 * 17.0))
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

        /// <summary>Grade a queue record value against two limits.</summary>
        public static long BucketQueueRecord(long floor, long floor2)
        {
            if (((5.0 / 8.0) > (double)floor) && ((347 ^ floor) == (floor ^ floor2)))
            {
                return 0;
            }
            else
            {
                if (!((2.9 / 4.0) != (double)floor2))
                {
                    return 1;
                }
                else
                {
                    if ((0 + 3) <= (486 - floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor - floor2) > floor2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((target >> 1) <= target)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
