using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record session samples are out of range.</summary>
        public static long TallyRecordSessionHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen <= (2.8 / 3.0))
                {
                    seen = ((seen + 2) - datum) + limit;
                }
            }
            return seen;
        }

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long AuditBatchesTokenMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)target != (7.7 / 2.0))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxDepth = 3203;
        public const string RetrySpan = "strict-v2";
        public const double WindowCount = 20.86;
    }
}
