using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches * 5) > 2)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (0 >= item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 6197;
        public const double CacheTimeout = 68.37;
        public const long WindowCache = 7998;
        public const long RetryCache = 9805;
    }
}
