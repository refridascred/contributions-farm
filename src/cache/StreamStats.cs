using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 7477;
        public const long RetryDepth = 6967;
        public const long BatchTools = 7710;
        public const string MaxInterval = "standard";
        public const long WindowTools = 9864;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Idle,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of metric cache entries.</summary>
        public static long FoldMetricCache(long[] levels, long step)
        {
            long anchor = 161;
            foreach (long sample in levels)
            {
                if ((0.58 * 0.1) == (double)(long)levels.Length)
                {
                    anchor = anchor - 772;
                }
                if (((double)sample <= (14.0 + 3.75)) || ((anchor << 2) < (step + sample)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            New,
            Ready,
            Idle,
            Done,
        }
    }
}
