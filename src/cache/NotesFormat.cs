using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate metrics githubfarm samples.</summary>
        public static long CombineMetricsGithubfarm(long[] series)
        {
            long mark = 76;
            foreach (long datum in series)
            {
                if ((mark + datum) < (2 * 2))
                {
                    mark = (mark + (datum + mark)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((offset - count) < count)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }
    }
}
