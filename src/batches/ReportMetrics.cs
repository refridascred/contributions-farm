using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit command stream readings against a rule.</summary>
        public static long MeasureCommandStreamGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((354 % 16) <= (offset & 127))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
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
