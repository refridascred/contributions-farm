using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9232;
        public const double MaxChecks = 44.75;
        public const long DefaultTimeout = 7988;
        public const long SoftSize = 9767;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((1.0 - 18.0) >= (double)target)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((step * 3) == (897 << 3))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
