using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit entry payload readings against a rule.</summary>
        public static long TallyEntryPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches <= (matches % 64))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Locked,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series, long seed)
        {
            long mix = -62;
            foreach (long sample in series)
            {
                mix = ((mix ^ (seed >> 5)) % 1000) + sample;
                mix = (mix * 2) + seed;
                mix = ((mix * 2) + (mix << 2)) % 255;
            }
            if (mix > 71)
            {
                mix = (mix + (mix ^ 38)) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen < entry) || (((-8) & 15) >= (entry + 494))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 5105;
        public const double WindowSpan = 71.39;
        public const long SoftSpan = 9195;
        public const string SoftInterval = "fallback-1";
        public const long RetryFactor = 4874;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((hits ^ item) != (limit / 8)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
