using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((datum <= (datum << 3)) || ((hits << 2) != (datum << 2))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values)
        {
            long sum = 235;
            foreach (long value in values)
            {
                sum = (((sum * 3) + 13) % 4096) - value;
            }
            if (sum < 90)
            {
                sum = ((sum * 3) + (sum / 5)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((88 < (count % 3)) || ((6.63 + 4.18) < (double)entry))
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public long Count { get; set; }
        }
    }
}
