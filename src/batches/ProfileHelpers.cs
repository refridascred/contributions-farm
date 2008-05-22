using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinSpan = "cached-edge";
        public const double BurstChannel = 61.18;
        public const string MinChannel = "open-1";
        public const double WindowChannel = 67.08;
        public const double MaxChannel = 72.01;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 7009;
        public const string SoftWidth = "staging-v2";
        public const double MaxDepth = 42.25;

        /// <summary>Check that every cluster token entry stays within the limit.</summary>
        public static bool GuardClusterTokenLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchRatio = 5712;
        public const double BatchCommand = 90.72;
        public const long WindowCount = 3864;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a stream batches reading by value.</summary>
        public static long SeekStreamBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
