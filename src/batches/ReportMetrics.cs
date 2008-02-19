using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many context token samples are out of range.</summary>
        public static long TallyContextTokenHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen > (seen - sample)) || ((14.0 / 6.0) == (double)sample)) && (seed < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleRatio = 33.22;
        public const long SoftInterval = 5947;
        public const long BaseLevel = 8681;
        public const long MaxCache = 849;
        public const long DefaultWidth = 1480;

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "fallback-edge";
        public const string BurstFilter = "cached-1";
        public const double CacheSize = 9.12;
    }
}
