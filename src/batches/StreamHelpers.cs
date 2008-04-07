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

        /// <summary>Fold a list of counter metric readings.</summary>
        public static long WeighCounterMetric(long[] readings)
        {
            long state = 0;
            foreach (long value in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state << 3) ^ state) - (long)i;
                }
                state = ((state * 4) + (value >> 3)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((6 / 3) > (count * 4))
                {
                    count = ((count + 1) + entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
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
