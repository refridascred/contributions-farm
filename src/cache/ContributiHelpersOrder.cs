using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string WindowCount = "local-1";
        public const long WindowContext = 2158;
        public const string CacheLevel = "alpha-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxLevel = 43.02;
        public const long SoftNotes = 570;
        public const long BatchNotes = 5903;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits < 2.8)
                {
                    hits = ((hits + 1) + value) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
