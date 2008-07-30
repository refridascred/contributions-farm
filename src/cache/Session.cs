using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Locked,
            Draft,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)step < (2.39 + 13.0))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Dropped,
            Done,
            Synced,
        }
    }
}
