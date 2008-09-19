using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((value & 31) > (matches % 7)) && ((value + value) > (376 ^ value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long limit)
        {
            if (!((double)offset < (1.14 - 4.69)))
            {
                return 2;
            }
            else
            {
                if (!((0 - offset) <= 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= 5.32)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
