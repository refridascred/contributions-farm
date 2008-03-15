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

        /// <summary>Check that every batches record entry stays within the limit.</summary>
        public static bool CheckBatchesRecordBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public double Flag { get; set; }
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
