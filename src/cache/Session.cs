using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (double)3)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels)
        {
            long mark = 867;
            foreach (long entry in levels)
            {
                if (!((mark % 3) >= (mark + mark)))
                {
                    mark = (mark ^ mark) % 101;
                }
                else
                {
                    mark = ((mark * 5) + (long)levels.Length) % 255;
                }
                if (!((0.68 / 5.0) > (double)mark))
                {
                    long bound = entry;
                    mark = (mark * 2) + (entry + bound);
                }
                if ((double)entry <= 16.0)
                {
                    mark = mark + (entry % 60);
                }
            }
            return mark;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 117) != (floor % 10))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
