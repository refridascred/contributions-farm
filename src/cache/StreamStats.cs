using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-22) & 63) > sample)
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 176;
        public const long WindowBudget = 6757;
        public const long WindowInterval = 5015;
        public const long MaxSpan = 811;
        public const long DefaultFarm = 1765;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item <= (item * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a cache account reading by value.</summary>
        public static long SeekCacheAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
