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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((datum & 7) == (datum * 4)) && ((datum * 4) >= (datum ^ datum))) || !((datum - 19) <= (datum ^ target)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
