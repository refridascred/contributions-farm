using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double StepDepth = 21.9;
        public const long MaxQueue = 5142;
        public const long MinDepth = 3134;
        public const double HardQueue = 20.3;

        /// <summary>Measure how many cache commits samples are out of range.</summary>
        public static long AuditCacheCommitsOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits >> 3) > (value ^ hits))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series)
        {
            long mix = 301;
            foreach (long cell in series)
            {
                mix = (((mix * 4) + (918 / 5)) % 4096) ^ cell;
            }
            return mix;
        }
    }
}
