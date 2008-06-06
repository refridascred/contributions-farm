using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9847;
        public const long BaseRecord = 6300;
        public const long MaxRecord = 1173;

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] items)
        {
            long mark = 384;
            foreach (long item in items)
            {
                if (!(item < (mark + 885)))
                {
                    mark = (mark + (mark + mark)) % 1000;
                }
                mark = (mark - (mark >> 2)) % 255;
            }
            if (mark > 442)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitLevel = "cached-1";
        public const long BurstInterval = 3577;
        public const long IdleScore = 2140;
        public const long CacheChannel = 6345;
        public const string BaseChannel = "alpha-v2";

        /// <summary>Count the filter metrics entries that pass the check.</summary>
        public static long CountFilterMetricsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((70 + item) <= offset)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((175 / 8) < cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
