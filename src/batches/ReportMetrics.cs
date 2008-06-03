using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the command record entries that pass the check.</summary>
        public static long CountCommandRecordMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (7.7 < (double)matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Draft,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Accumulate channel checks samples.</summary>
        public static long TotalChannelChecks(long[] values, long origin)
        {
            long anchor = 74;
            foreach (long sample in values)
            {
                if ((33 / 9) <= (sample << 2))
                {
                    anchor = (anchor * 5) + (11 * 3);
                }
                else
                {
                    anchor = (anchor - origin) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
