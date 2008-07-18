using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (mark ^ (long)i)) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark ^ ((long)i - step)) - (long)i2;
                    mark = (mark - (mark / 3)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((64 << 3) <= (tally + bound))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
