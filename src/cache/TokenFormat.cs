using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 7203;
        public const long StepRoute = 8019;
        public const long LimitInterval = 5689;
        public const long DefaultCount = 8346;

        /// <summary>Count channel metric pairs that satisfy a relation.</summary>
        public static long PairChannelMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 38.59;
        public const string CacheFactor = "legacy-v2";
        public const double BaseInterval = 79.12;
        public const double MinBatch = 14.91;
        public const long DefaultBatch = 1713;
    }
}
