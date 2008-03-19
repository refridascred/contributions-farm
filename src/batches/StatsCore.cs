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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((8 >> 1) >= (count ^ count)) || ((3.3 + 8.6) >= (double)count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long mark = 845;
            foreach (long sample in items)
            {
                if (((long)items.Length < (mark + mark)) && ((17 << 1) < (sample ^ target)))
                {
                    mark = (mark - (mark << 2)) % 4096;
                }
            }
            if (mark < 115)
            {
                mark = (mark + (43 & 7)) % 97;
            }
            return mark;
        }
    }
}
