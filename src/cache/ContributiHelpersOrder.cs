using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every support notes entry stays within the limit.</summary>
        public static bool GuardSupportNotesBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum >> 4) >= (tally % 64))
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

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 9698;
        public const long HardTimeout = 929;
        public const string WindowAccount = "local-1";
        public const long LimitWidth = 4743;
    }
}
