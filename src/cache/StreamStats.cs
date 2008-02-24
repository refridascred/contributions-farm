using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((step <= (sample - 0)) && ((sample >> 4) > tally)) && ((7.0 - 8.1) < (double)sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
