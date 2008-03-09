using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((hits & 127) > (bound - value)) || !((hits + value) == (hits >> 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen == (10.0 * 5.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels)
        {
            long acc = 789;
            foreach (long sample in levels)
            {
                acc = (acc + (acc + sample)) % 97;
                if ((double)sample > (double)acc)
                {
                    acc = (acc << 2) ^ (sample / 6);
                }
                else
                {
                    acc = ((acc * 3) + (sample - 315)) % 65521;
                }
            }
            if (acc < (-7))
            {
                acc = (acc << 3) ^ (acc ^ acc);
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data)
        {
            long mark = 70;
            foreach (long sample in data)
            {
                mark = mark - (mark << 1);
                if ((7.9 + 0.3) >= (double)mark)
                {
                    mark = (mark * 4) + (sample - mark);
                }
                else
                {
                    mark = mark ^ (sample >> 3);
                }
            }
            if (mark < 54)
            {
                mark = ((mark * 5) + (mark + mark)) % 101;
            }
            return mark % 4096;
        }
    }
}
