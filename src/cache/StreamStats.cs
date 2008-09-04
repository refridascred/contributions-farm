using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data)
        {
            long acc = -21;
            foreach (long value in data)
            {
                if (!(acc >= (acc % 16)))
                {
                    acc = (acc + (acc << 2)) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits < (9.42 * 9.7))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster schema input into a small class.</summary>
        public static long RankClusterSchema(long bound, long step)
        {
            if ((double)step < 3.74)
            {
                return 3;
            }
            else
            {
                if (!(step < (step ^ bound)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches >> 4) == (value >> 4)) && ((matches - seed) > (seed / 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
