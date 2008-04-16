using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((seed & 31) > mark) && ((6.7 * 1.35) <= (double)(long)i))
                {
                    mark = (mark << 2) ^ (seed & 7);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((13.0 / 3.0) == (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
