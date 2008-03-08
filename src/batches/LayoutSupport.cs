using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((tally / 8) > value))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of report cache readings.</summary>
        public static long CombineReportCache(long[] levels, long target)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if (2.36 < (double)cell)
                {
                    mark = ((mark * 5) + ((long)levels.Length - mark)) % 97;
                    break;
                }
                if (((3.57 - 0.6) == (double)cell) || ((mark * 4) > (mark - 271)))
                {
                    mark = mark ^ (target << 1);
                }
                else
                {
                    mark = (mark ^ target) % 1000;
                }
            }
            return mark;
        }
    }
}
