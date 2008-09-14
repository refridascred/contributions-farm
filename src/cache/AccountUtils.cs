using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) > (724 + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels, long origin)
        {
            long anchor = 9;
            foreach (long cell in levels)
            {
                if ((double)anchor != (15.0 / 3.0))
                {
                    anchor = (anchor ^ (cell * 5)) - origin;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Idle,
            Ready,
        }
    }
}
