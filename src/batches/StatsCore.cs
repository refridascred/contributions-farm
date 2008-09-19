using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long limit)
        {
            if (!((2.6 * 6.3) >= (double)limit))
            {
                return 2;
            }
            else
            {
                if ((3.1 + 15.0) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Check that every context cluster entry stays within the limit.</summary>
        public static bool GuardContextClusterBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Pending,
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Active,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample ^ matches) == (sample << 3)) && ((matches + 117) == (sample ^ sample)))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
