using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit commits metric readings against a rule.</summary>
        public static long TallyCommitsMetricMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((limit - tally) <= (limit ^ (-907)))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
