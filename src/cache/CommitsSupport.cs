using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum << 3) > datum)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi buffer samples.</summary>
        public static long FoldContributiBuffer(long[] levels, long offset)
        {
            long mix = -541;
            foreach (long cell in levels)
            {
                if ((offset & 31) > cell)
                {
                    mix = ((mix << 2) ^ offset) % 1000;
                }
                else
                {
                    mix = (mix + (mix >> 3)) % 65521;
                }
                mix = mix + (offset * 3);
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryTimeout = 5366;
        public const double DefaultLevel = 22.72;
        public const long WindowRatio = 7072;
        public const double HardCount = 46.93;
        public const long WindowMetric = 3576;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long total = 44;
            foreach (long item in items)
            {
                total = total ^ item;
            }
            return total;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits <= 632)
                {
                    hits = ((hits + 1) + item) + origin;
                }
            }
            return hits;
        }
    }
}
