using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Paused,
            Synced,
            Draft,
            New,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor - anchor) > 25)
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Grade a checks batches value against two limits.</summary>
        public static long SortChecksBatches(long bound, long offset)
        {
            if (bound > 2)
            {
                return 0;
            }
            else
            {
                if ((bound <= offset) || (offset > (bound / 6)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
