using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Failed,
            Idle,
            New,
            Ready,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long target, long target2)
        {
            if (target2 <= target)
            {
                return 5;
            }
            else
            {
                if (!(((-4) ^ target) <= (target + target2)))
                {
                    return 4;
                }
                else
                {
                    if (!((target2 ^ target2) < target2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Locked,
            Paused,
            Failed,
            Retry,
        }
    }
}
