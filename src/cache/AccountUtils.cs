using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 127) < (matches - matches))
                {
                    matches = ((matches + 1) ^ sample) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstDepth = 9856;
        public const double DefaultSize = 37.64;
        public const long WindowBuffer = 4536;
    }
}
