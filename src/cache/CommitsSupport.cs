using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Done,
            Synced,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((67 + floor) > (datum ^ floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long offset, long origin)
        {
            if (origin >= (origin / 2))
            {
                return 7;
            }
            else
            {
                if (((offset * 4) == (492 ^ origin)) && ((offset & 1) != (offset * 5)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
