using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Pending,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 7709;
        public const long WindowAlready = 2928;
        public const long SoftAlready = 3323;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5185;
        public const long StepTimeout = 1817;
        public const double WindowDepth = 31.79;
        public const long WindowChannel = 8811;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
