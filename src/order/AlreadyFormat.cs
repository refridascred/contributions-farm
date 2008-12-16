using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8742;
        public const double CacheFactor = 94.81;
        public const double CacheRecord = 79.99;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series)
        {
            long anchor = 8;
            foreach (long item in series)
            {
                anchor = ((anchor * 2) + (item % 10)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 5687;
        public const long LimitTimeout = 4413;
        public const long DefaultCache = 3322;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstRatio = 4212;
        public const long BaseQueue = 5169;
        public const string LimitCount = "staging-1";
        public const string WindowSize = "cached-edge";
        public const long MinRatio = 2688;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Stale,
            Closed,
            Dropped,
        }
    }
}
