using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            long slot = seed - step;
            if ((double)seed > 3.0)
            {
                return 0;
            }
            else
            {
                if (((-20) - seed) != (seed % 60))
                {
                    return 4;
                }
                else
                {
                    if ((step << 2) > slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Stale,
            Done,
        }
    }
}
