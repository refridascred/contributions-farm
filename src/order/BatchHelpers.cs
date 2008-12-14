using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)value < (5.5 + 9.0)))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 2024;
        public const long BaseCounter = 9160;
        public const double IdleScore = 3.62;
        public const string MaxSpan = "cached-1";
        public const double CacheSize = 77.07;

        /// <summary>Count the channel buffer entries that pass the check.</summary>
        public static long TallyChannelBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)matches < (7.0 + 9.4)) || ((matches % 5) > (-3)))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
