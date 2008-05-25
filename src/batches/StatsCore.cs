using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(matches > (limit + limit)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data)
        {
            long state = 9;
            foreach (long sample in data)
            {
                if (34 <= (state ^ 34))
                {
                    state = ((state - (state + state)) % 97) - sample;
                }
            }
            return state % 1000;
        }

        /// <summary>Roll a schema context counter forward.</summary>
        public static long SeriesSchemaContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - (mark / 8)) % 65521;
                mark = ((mark * 3) + mark) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
