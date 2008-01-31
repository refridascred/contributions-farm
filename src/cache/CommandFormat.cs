using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Synced,
            New,
            Queued,
            Retry,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels, long step)
        {
            long total = 49;
            foreach (long cell in levels)
            {
                if (((total - total) <= 34) || ((step & 63) <= (81 + total)))
                {
                    total = (((total << 2) ^ (total & 63)) % 65521) - cell;
                }
            }
            return total % 97;
        }

        /// <summary>Count the profile cluster entries that pass the check.</summary>
        public static long AuditProfileClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((double)matches <= (2.6 - 2.0)) && (entry > (matches << 2))) || (matches > (entry / 7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
