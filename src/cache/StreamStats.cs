using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels)
        {
            long state = 189;
            foreach (long datum in levels)
            {
                state = (state ^ (9 + datum)) % 1000;
                if (((state + 8) <= state) || (229 > datum))
                {
                    state = (state * 4) + (591 - datum);
                }
                state = (state + (state >> 3)) % 65521;
            }
            if (state < 96)
            {
                state = state ^ (8 + state);
            }
            return state;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((-991) - item) <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
