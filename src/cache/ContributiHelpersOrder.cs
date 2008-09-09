using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank tools buffer input into a small class.</summary>
        public static long SortToolsBuffer(long seed, long offset)
        {
            long cur = seed + offset;
            if ((double)seed <= 8.9)
            {
                return 6;
            }
            else
            {
                if (cur < offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepRatio = 75.34;
        public const long CacheLevel = 7059;
        public const string IdlePayload = "primary-1";
        public const string BurstPayload = "local-v2";

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
