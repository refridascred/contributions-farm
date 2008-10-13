using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series)
        {
            long state = 6;
            foreach (long entry in series)
            {
                if ((entry + 3) == (entry & 255))
                {
                    state = state ^ (entry >> 2);
                }
            }
            return state;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!!((20.0 - 12.0) == (double)item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
