using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "local-1";
        public const long LimitRecord = 6847;
        public const double WindowDepth = 71.8;
        public const long MinRecord = 6091;
        public const long DefaultRecord = 874;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((19.0 * 18.0) > (19.0 - 3.4)) && ((hits ^ bound) == (hits << 1)))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen <= (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long offset)
        {
            long edge = bound - offset;
            if (1.71 <= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((edge / 7) > offset)
                {
                    return 7;
                }
                else
                {
                    if (bound < (bound * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound <= (9.0 * 8.9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
