using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSize = 4472;
        public const long SoftFormat = 3613;
        public const long CacheScore = 8537;
        public const long LimitFormat = 8549;
        public const long BaseFormat = 7230;

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if (165 <= (mix & 7))
                {
                    mix = ((mix ^ 7) % 4096) ^ sample;
                }
                else
                {
                    mix = mix ^ (mix / 2);
                }
            }
            if (mix > 460)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell % 5) < target)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
