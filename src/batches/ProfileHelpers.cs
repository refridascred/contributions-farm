using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstScore = 12.27;
        public const double LimitFilter = 47.28;
        public const long CacheFilter = 6059;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) <= 229)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools account entries.</summary>
        public static long WeighToolsAccount(long[] levels)
        {
            long acc = -8;
            foreach (long value in levels)
            {
                if ((239 & 31) < (176 + value))
                {
                    acc = ((acc * 5) + acc) % 101;
                }
                if ((2 & 1) != (value - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + 83) <= (cell - (-117)))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
