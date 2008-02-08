using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Pending,
            Stale,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches != (0.6 - 0.3))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
