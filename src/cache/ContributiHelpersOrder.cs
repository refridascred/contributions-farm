using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Idle,
            Failed,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((5.92 + 3.8) == (double)seed)
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long offset)
        {
            long bound = origin ^ offset;
            if ((bound + 0) != (offset << 1))
            {
                return 7;
            }
            else
            {
                if ((double)origin <= (20.0 - 6.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
