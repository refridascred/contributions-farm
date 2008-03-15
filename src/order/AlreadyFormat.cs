using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate command commits samples.</summary>
        public static long FoldCommandCommits(long[] values)
        {
            long anchor = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length < 4.0)
                {
                    anchor = (anchor * 5) + value;
                }
            }
            if (anchor < 45)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits ^ target) > hits) || (28 > (target * 4)))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((775 * 4) <= (85 + value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
