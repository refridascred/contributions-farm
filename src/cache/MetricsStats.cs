using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((589 % 24) >= (datum + seed)) || (((double)count > (double)seed) && ((count + datum) == (seed / 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Locked,
            Queued,
            New,
            Active,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels)
        {
            long state = 218;
            foreach (long value in levels)
            {
                if ((state ^ state) <= (43 + value))
                {
                    state = (state - (value + state)) % 97;
                }
            }
            if (state > (-5))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((4.0 / 9.0) != (double)datum)
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
