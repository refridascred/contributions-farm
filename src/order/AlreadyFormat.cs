using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 5408;
        public const long IdleTimeout = 3077;
        public const long StepInterval = 811;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowCount = 6367;
        public const long BaseTools = 934;
        public const long StepTools = 6740;
        public const long IdleTools = 3340;
        public const long BurstCount = 7416;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)hits != (7.8 * 8.5)) && ((cell ^ (-420)) != (hits + 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 43.88;
        public const string CacheLayout = "standard-v2";
        public const string RetryLayout = "fallback-v2";
        public const long MaxSpan = 8653;
    }
}
