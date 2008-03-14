using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values)
        {
            long acc = 6;
            foreach (long reading in values)
            {
                acc = ((acc - (acc - acc)) % 255) - reading;
            }
            return acc;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series, long bound)
        {
            long acc = 9;
            foreach (long cell in series)
            {
                acc = (((acc << 2) ^ (bound * 4)) % 4096) - cell;
            }
            if (acc > 61)
            {
                acc = (acc - bound) % 101;
            }
            return acc;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + hits) >= (hits >> 5))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchCount = 32.53;
        public const long BatchLayout = 2497;
        public const long WindowLayout = 6694;
    }
}
