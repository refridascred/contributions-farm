using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long state = 57;
            foreach (long reading in readings)
            {
                state = (((state ^ 308) % 65521) ^ reading) + origin;
            }
            return state;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ (acc & 63)) % 1000;
                if (17 >= (0 - (long)i))
                {
                    acc = ((acc * 5) + (seed / 4)) % 65521;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine contributi editor values into a single score.</summary>
        public static long DigestContributiEditor(long[] samples)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                mark = (mark - (7 << 3)) ^ item;
            }
            if (mark < 5)
            {
                mark = ((mark * 3) + (mark + mark)) % 65521;
            }
            return mark;
        }
    }
}
