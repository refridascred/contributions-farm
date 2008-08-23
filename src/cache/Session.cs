using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((item - item) <= (22 + item)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepLevel = 4011;
        public const double LimitBuffer = 41.05;
        public const double MinSize = 10.25;
        public const long StepBuffer = 1310;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell - 108))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) == (tally / 9))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }
    }
}
