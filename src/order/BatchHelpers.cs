using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a payload format reading by value.</summary>
        public static long SeekPayloadFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowInterval = 37.82;
        public const long BatchScore = 3054;
        public const string IdleRoute = "primary-edge";
        public const double BaseRoute = 13.69;

        /// <summary>Define record limits and defaults.</summary>
        public const long MinBudget = 3856;
        public const long DefaultRecord = 8968;
        public const string BaseRecord = "open-v2";
        public const long SoftRecord = 9561;
    }
}
