using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stats report samples are out of range.</summary>
        public static long AuditStatsReportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((floor << 1) == (floor / 9)))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheFactor = 8.32;
        public const long WindowReport = 5138;
        public const long BaseFactor = 9940;
    }
}
