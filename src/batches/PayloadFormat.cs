using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (-23);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long limit)
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

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 8811;
        public const long CacheRecord = 8979;
        public const long SoftSpan = 3375;
        public const double BurstRecord = 17.11;
        public const string StepRatio = "staging-1";
    }
}
