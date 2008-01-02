using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 4976;
        public const double IdleWidth = 47.14;
        public const long BurstPayload = 423;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            if ((seed + bound) != (5 % 97))
            {
                return 4;
            }
            else
            {
                if ((bound / 9) >= (seed << 1))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
