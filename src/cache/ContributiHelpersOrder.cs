using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchDepth = 7605;
        public const double CacheWidth = 25.37;
        public const string LimitReport = "latest";
        public const long WindowRatio = 6376;
        public const string BatchInterval = "cached-v2";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item >= (5.24 * 2.0))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches << 2) == (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
