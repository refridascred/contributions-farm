using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Done,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Idle,
            Closed,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (entry + entry)) && ((matches + matches) >= (entry / 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
