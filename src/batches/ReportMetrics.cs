using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the context report entries that pass the check.</summary>
        public static long CountContextReportHits(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell / 7) <= 76)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long limit, long floor)
        {
            if (((double)floor <= 0.1) && ((limit % 5) < floor))
            {
                return 3;
            }
            else
            {
                if ((16.0 / 7.0) <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((limit * 5) >= (limit / 2)) || ((limit * 2) != (floor + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            New,
            Queued,
        }
    }
}
