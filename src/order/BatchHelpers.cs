using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLevel = 53.74;
        public const long BatchLayout = 4442;
        public const double DefaultLayout = 71.43;
        public const string WindowCount = "strict";
        public const string BurstDepth = "fallback-1";

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Dropped,
            Idle,
            Stale,
        }
    }
}
