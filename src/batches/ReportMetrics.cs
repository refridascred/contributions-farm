using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound >> 4) < (mark / 9))
                {
                    mark = mark + (bound & 31);
                }
                else
                {
                    mark = (mark - ((long)i + 2)) % 101;
                }
                mark = ((mark << 2) ^ (2 & 7)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            New,
            Stale,
        }
    }
}
