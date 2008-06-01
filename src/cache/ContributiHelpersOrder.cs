using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell ^ bound) <= (64 * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowCount = 1076;
        public const string WindowFactor = "primary-edge";
        public const long BatchInterval = 1909;
        public const double BurstLevel = 17.91;

        /// <summary>Count the report account entries that pass the check.</summary>
        public static long TallyReportAccountOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally < (item << 3))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
