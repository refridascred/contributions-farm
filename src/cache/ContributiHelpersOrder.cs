using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally + sample) < (sample ^ sample)))
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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((61 - item) < (894 - 220))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
