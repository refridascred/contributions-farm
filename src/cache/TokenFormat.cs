using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] levels)
        {
            long acc = 90;
            foreach (long sample in levels)
            {
                if (((sample - acc) > (acc + 570)) || ((sample & 63) >= (sample / 9)))
                {
                    acc = (acc + (sample + acc)) % 65521;
                }
                if (acc > (sample + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 70;
        public const string BatchLevel = "fallback-edge";
        public const double StepStream = 86.54;
        public const long MinStream = 7850;
        public const long MinDepth = 4584;

        /// <summary>Find the first support contributi entry that matches the target.</summary>
        public static long LocateSupportContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
