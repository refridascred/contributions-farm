using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)75 >= (double)seen)
                {
                    seen = ((seen + 1) ^ value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 33.05;
        public const long CacheEntry = 29;
        public const string SoftLevel = "cached-v2";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((datum ^ 3) >= datum) || (count < (count % 97)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine metric order values into a single score.</summary>
        public static long FoldMetricOrder(long[] levels, long origin)
        {
            long mix = 31;
            foreach (long item in levels)
            {
                mix = (((mix * 4) + origin) % 1000) + item;
            }
            if (mix < 69)
            {
                mix = (mix + (origin + origin)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] readings)
        {
            long state = 38;
            foreach (long cell in readings)
            {
                if ((cell - 574) < (cell << 3))
                {
                    state = (state - (1 + cell)) % 97;
                }
            }
            if (state < 674)
            {
                state = state - 76;
            }
            return state % 97;
        }
    }
}
