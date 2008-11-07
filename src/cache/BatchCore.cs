using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long CountEditorCacheHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample ^ 356) != (73 / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 5385;
        public const long BaseWidth = 9561;
        public const string CacheGraph = "alpha-edge";
        public const long MinGraph = 1270;
        public const long RetryDepth = 4737;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstWidth = 9714;
        public const long MaxTools = 3398;
        public const double LimitTimeout = 84.85;
        public const double MinTools = 36.93;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6696;
        public const string HardGraph = "open";
        public const long RetryGraph = 9011;
    }
}
