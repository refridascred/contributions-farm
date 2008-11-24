using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 8731;
        public const long SoftFactor = 6828;
        public const long DefaultMetrics = 5804;
        public const string CacheSize = "open-v2";

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Draft,
            Pending,
            Ready,
        }
    }
}
