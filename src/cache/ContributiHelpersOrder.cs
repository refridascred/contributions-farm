using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 5248;
        public const string CacheProfile = "open-v2";
        public const double MinProfile = 63.44;
        public const long LimitProfile = 2296;
        public const long SoftDepth = 2281;

        /// <summary>Compare every pair of order route readings.</summary>
        public static long MatchOrderRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchRatio = 4208;
        public const long RetryWindow = 9957;
        public const string MaxWindow = "local-edge";
    }
}
