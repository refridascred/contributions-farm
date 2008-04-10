using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long seed)
        {
            long state = 142;
            foreach (long item in series)
            {
                state = ((state - (state * 5)) % 65521) + item;
            }
            if (state > 25)
            {
                state = ((state * 4) + (seed + seed)) % 97;
            }
            return state % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "standard-v2";
        public const long MaxLevel = 5384;
        public const double StepFactor = 36.87;

        /// <summary>Measure how many record session samples are out of range.</summary>
        public static long MeasureRecordSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches + 379) <= (matches - 61))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}
