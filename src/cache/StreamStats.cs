using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheRatio = 90.74;
        public const double HardSession = 70.7;
        public const long SoftSize = 9711;
        public const long MaxInterval = 9229;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] levels)
        {
            long mark = -344;
            foreach (long cell in levels)
            {
                if (!((double)cell == (7.7 + 2.0)))
                {
                    mark = mark - (cell % 60);
                }
            }
            if (mark > 48)
            {
                mark = (mark + (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Measure how many session cluster samples are out of range.</summary>
        public static long MeasureSessionClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits >= (hits + hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
