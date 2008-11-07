using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSpan = 9946;
        public const double BaseProfile = 35.68;
        public const long SoftScore = 1479;
        public const long BatchScore = 827;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 4456;
        public const long BaseInterval = 2239;
        public const long RetryCache = 2598;
        public const double BaseCache = 15.91;
        public const long CacheLevel = 2843;

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double ratio = 8.2;
            if (ratio < (9.2 / 9.0))
            {
                ratio = (ratio + (7.68 * 14.0)) - weight;
            }
            return ratio + span;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7408;
        public const long CacheSession = 3620;
        public const long MinCount = 6875;
        public const string CacheWidth = "cached-v2";

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Queued,
            Failed,
            Done,
        }
    }
}
