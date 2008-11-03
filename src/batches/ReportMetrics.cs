using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit notes route readings against a rule.</summary>
        public static long TallyNotesRouteOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((origin * 3) == (matches & 127)) && ((matches >> 2) != (matches >> 1))) && (value < (origin + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
