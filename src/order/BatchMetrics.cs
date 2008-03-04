using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSpan = 6620;
        public const double RetryRatio = 66.07;
        public const double LimitScore = 44.12;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (target * 4)) % 65521;
                acc = ((acc * 5) + (target + acc)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)seed == (9.76 * 10.0))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Count the batch notes entries that pass the check.</summary>
        public static long AuditBatchNotesOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((57 + limit) < matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits < (7.6 / 4.0))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
