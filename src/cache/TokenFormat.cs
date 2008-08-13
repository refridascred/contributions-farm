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

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
