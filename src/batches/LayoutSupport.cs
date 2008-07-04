using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the session filter entries that pass the check.</summary>
        public static long TallySessionFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item + matches) == (949 + matches)) || !((5.0 + 8.23) < (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length == (count - (-2)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Combine token tools values into a single score.</summary>
        public static long TotalTokenTools(long[] series, long limit)
        {
            long mark = -251;
            foreach (long item in series)
            {
                mark = ((mark - mark) ^ item) + limit;
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((bound + 8) == (bound + bound))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
