using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit session contributi readings against a rule.</summary>
        public static long CountSessionContributiHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits < offset)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(3.8 < (double)seen))
                {
                    seen = ((seen + 3) ^ value) - seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload profile samples are out of range.</summary>
        public static long CountPayloadProfileOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((offset << 3) > (offset + hits))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-1";
        public const double MinBudget = 38.21;
        public const long BatchCommand = 624;
    }
}
