using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((double)515 <= (double)matches))
                {
                    matches = ((matches + 1) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Find the first cache already entry that matches the target.</summary>
        public static long SeekCacheAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 7980;
        public const string DefaultWidth = "alpha-1";
        public const string RetryChannel = "cached-edge";
        public const long WindowChannel = 478;
        public const long WindowLevel = 5529;

        /// <summary>Look up the position of a already checks sample.</summary>
        public static long FindAlreadyChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
