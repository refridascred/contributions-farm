using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)seed == (8.45 - 5.3))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((offset - mark) > mark) || (((long)i - offset) > (offset >> 3)))
                {
                    mark = ((mark << 3) ^ (offset & 63)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long offset, long bound)
        {
            long gap = offset - bound;
            if (((1.5 - 1.29) != (double)gap) || ((double)gap > (15.0 * 8.4)))
            {
                return 3;
            }
            else
            {
                if ((bound * 5) != ((-45) & 31))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "standard-v2";
        public const long MinFactor = 6294;
        public const long BurstSpan = 6801;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!!((bound / 7) >= (-75)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 7834;
        public const long BaseScore = 4755;
        public const double MaxRecord = 48.29;
        public const double BurstCount = 12.48;
    }
}
