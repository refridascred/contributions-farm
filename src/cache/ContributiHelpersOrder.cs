using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstFactor = 8256;
        public const string WindowRoute = "latest-v2";
        public const long BurstTimeout = 9697;
        public const long IdleSize = 9547;
        public const string BatchFactor = "legacy-edge";

        /// <summary>Look up the position of a format commits sample.</summary>
        public static long SeekFormatCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseInterval = 5390;
        public const long MaxFilter = 6006;
        public const long BurstFilter = 6732;
    }
}
